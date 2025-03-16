

Solução Proposta
1. Modificar o FormCadastroDespesa
Vamos adicionar uma propriedade ou lógica para controlar os eventos TextChanged com base no StatusOperacao. Aqui está o código ajustado:



public partial class FormCadastroDespesa : KryptonForm
{
    private readonly DespesasBLL objetoBll = new DespesasBLL();
    public string StatusOperacao { get; set; }
    private string QueryDespesa = "SELECT MAX(DespesaID) FROM Despesas";
    public bool Salvou { get; private set; } = false;
    private readonly FormManutencaoDespesas _formPai;
    public int DespesaID { get; set; }
    public List<DespesasModel> ParcelasGeradas { get; set; } = new List<DespesasModel>();
    private bool bloqueiaPesquisa = false;
    private bool bloqueiaEventosTextChanged = false; // Já existe no seu código

    public FormCadastroDespesa(string statusOperacao, FormManutencaoDespesas formPai)
    {
        InitializeComponent();
        StatusOperacao = statusOperacao;
        Utilitario.AdicionarEfeitoFocoEmTodos(this);
        _formPai = formPai;
        CarregarComboBoxes(); // Carrega os ComboBox
        ConfigurarFormularioInicial(); // Configurações iniciais
    }

    private void ConfigurarFormularioInicial()
    {
        if (StatusOperacao == "NOVO")
        {
            int codigo = Utilitario.GerarProximoCodigo(QueryDespesa);
            txtDespesaID.Text = Utilitario.AcrescentarZerosEsquerda(codigo, 5);
            bloqueiaEventosTextChanged = false; // Eventos habilitados no modo NOVO
        }
        else if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO" || StatusOperacao == "PAGAR")
        {
            bloqueiaEventosTextChanged = true; // Desabilita eventos nos modos ALTERAR, EXCLUSÃO e PAGAR
        }
        btnGerarParcelas.Visible = radiobtnSim.Checked;
    }

    // Eventos TextChanged ajustados
    private void txtCategoria_TextChanged(object sender, EventArgs e)
    {
        if (bloqueiaPesquisa || bloqueiaEventosTextChanged || string.IsNullOrEmpty(txtCategoria.Text))
            return;

        bloqueiaPesquisa = true;

        using (FormLocalizarCategoria pesquisaCategoria = new FormLocalizarCategoria(this, txtCategoria.Text))
        {
            pesquisaCategoria.Owner = this;

            if (pesquisaCategoria.ShowDialog() == DialogResult.OK)
            {
                txtCategoria.Text = pesquisaCategoria.categoriaSelecionado;
            }
        }

        Task.Delay(100).ContinueWith(t =>
        {
            Invoke(new Action(() => bloqueiaPesquisa = false));
        });
    }

    private void txtMetodoPgto_TextChanged(object sender, EventArgs e)
    {
        if (bloqueiaPesquisa || bloqueiaEventosTextChanged || string.IsNullOrEmpty(txtMetodoPgto.Text))
            return;

        bloqueiaPesquisa = true;

        using (FormLocalizarMetodoPagamento pesquisaMetodoPgto = new FormLocalizarMetodoPagamento(this, txtMetodoPgto.Text))
        {
            pesquisaMetodoPgto.Owner = this;

            if (pesquisaMetodoPgto.ShowDialog() == DialogResult.OK)
            {
                txtMetodoPgto.Text = pesquisaMetodoPgto.metodoPgtoSelecionado;
            }
        }

        Task.Delay(100).ContinueWith(t =>
        {
            Invoke(new Action(() => bloqueiaPesquisa = false));
        });
    }

    // Restante do código (CarregarComboBoxes, btnSalvar_Click, etc.) permanece igual
}



2. Explicação das Mudanças
bloqueiaEventosTextChanged:
Já existe no seu código como uma variável de controle. Estamos aproveitando ela para desabilitar os eventos TextChanged.
No método ConfigurarFormularioInicial, definimos bloqueiaEventosTextChanged = true para os modos "ALTERAR", "EXCLUSÃO" e "PAGAR", e false para "NOVO".
Eventos TextChanged:
Os eventos já verificam bloqueiaEventosTextChanged. Quando true, o código dentro dos eventos é ignorado, efetivamente "desabilitando" a lógica de pesquisa.
3. O Método PreencherCampos no FormManutencaoDespesas
O método PreencherCampos está correto para preencher os TextBox (txtCategoria e txtMetodoPgto) com os nomes, mas não precisa de ajustes adicionais para desabilitar os eventos, já que isso é controlado no FormCadastroDespesa. Aqui está como ele está atualmente:


private void PreencherCampos(FormCadastroDespesa form)
{
    if (TipoAtual != null)
    {
        form.txtDespesaID.Text = TipoAtual.DespesaID.ToString();
        form.txtDescricao.Text = TipoAtual.Descricao;
        form.txtValor.Text = TipoAtual.Valor.ToString();
        form.dtpDataVencimento.Value = TipoAtual.DataVencimento;
        form.cmbStatus.SelectedItem = TipoAtual.Status;
        form.txtNumeroParcelas.Text = TipoAtual.NumeroParcelas.ToString();
        form.txtValorParcela.Text = TipoAtual.ValorParcela.ToString();

        form.CategoriaID = Convert.ToInt32(TipoAtual.CategoriaID);
        form.MetodoPgtoID = Convert.ToInt32(TipoAtual.MetodoPgtoID);

        int _categoriaID = Convert.ToInt32(TipoAtual.CategoriaID);
        form.txtCategoria.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("Categorias", "CategoriaID", "NomeCategoria", _categoriaID);

        int _metodoPgtoID = Convert.ToInt32(TipoAtual.MetodoPgtoID);
        form.txtMetodoPgto.Text = Utilitario.PesquisarPorCodigoExibirEmTexbox("MetodosPagamento", "MetodoPgtoID", "NomeMetodoPagamento", _metodoPgtoID);
    }
}



Nota: Como você está preenchendo txtCategoria e txtMetodoPgto diretamente com os nomes via Utilitario.PesquisarPorCodigoExibirEmTexbox, os eventos TextChanged seriam disparados ao definir esses valores. Com o bloqueiaEventosTextChanged = true, isso não acontece mais nos modos desejados.
Alternativa: Remover os Eventos Dinamicamente
Se você preferir remover os eventos completamente em vez de usar uma flag de controle, pode fazer assim:

No FormCadastroDespesa
csharp


public FormCadastroDespesa(string statusOperacao, FormManutencaoDespesas formPai)
{
    InitializeComponent();
    StatusOperacao = statusOperacao;
    Utilitario.AdicionarEfeitoFocoEmTodos(this);
    _formPai = formPai;
    CarregarComboBoxes();

    // Desabilitar eventos TextChanged nos modos ALTERAR, EXCLUSÃO e PAGAR
    if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO" || StatusOperacao == "PAGAR")
    {
        txtCategoria.TextChanged -= txtCategoria_TextChanged;
        txtMetodoPgto.TextChanged -= txtMetodoPgto_TextChanged;
    }

    ConfigurarFormularioInicial();
}

// Re-adicionar os eventos ao fechar o formulário, se necessário
protected override void OnFormClosing(FormClosingEventArgs e)
{
    if (StatusOperacao == "ALTERAR" || StatusOperacao == "EXCLUSÃO" || StatusOperacao == "PAGAR")
    {
        txtCategoria.TextChanged += txtCategoria_TextChanged;
        txtMetodoPgto.TextChanged += txtMetodoPgto_TextChanged;
    }
    base.OnFormClosing(e);
}


Vantagem: Remove os eventos completamente, evitando qualquer possibilidade de execução acidental.
Desvantagem: Mais código e gerenciamento manual dos eventos.
Teste
No FormManutencaoDespesas, selecione um registro e clique em "Alterar", "Excluir" ou "Pagar".
O FormCadastroDespesa deve abrir com os TextBox (txtCategoria e txtMetodoPgto) preenchidos com os nomes, e os eventos TextChanged não devem ser disparados (nenhum formulário de pesquisa deve abrir).
No modo "NOVO", os eventos devem continuar funcionando normalmente.
Se ainda houver algum problema, me avise o que aconteceu (ex.: eventos ainda dispararam, nomes não apareceram, etc.), e eu ajusto!






