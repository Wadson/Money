using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Money
{
    public partial class FrmCadastroContasPagar : Money.FrmBaseGeral
    {

        public int NumParcela { get; set; }public double ValorParcela { get; set; } public double ValorTotal { get; set; }
        public double Desconto { get; set; }
        public double Acrescimo { get; set; }
        public double Entrada { get; set; } 

        public FrmCadastroContasPagar()
        {
            InitializeComponent();
        }
        public void AcrescenteZero_a_Esquerda()
        {
            string texto;
            string textofinal;
            int tamanho;
            textofinal = "";
            texto = txtCodigo.Text.ToString();
            if ((txtCodigo.Text.Length < 6))
            {
                tamanho = txtCodigo.Text.Length;
                for (int t = 1; (t <= (6 - tamanho)); t++)
                {
                    textofinal = (textofinal + "0");
                }

                txtCodigo.Text = (textofinal + txtCodigo.Text);
            }

        }
        public void AcrescenteZero_a_Esquerda_Forn()
        {
            string texto;
            string textofinal;
            int tamanho;
            textofinal = "";
            texto = txtCodigoForn.Text.ToString();
            if ((txtCodigoForn.Text.Length < 6))
            {
                tamanho = txtCodigoForn.Text.Length;
                for (int t = 1; (t <= (6 - tamanho)); t++)
                {
                    textofinal = (textofinal + "0");
                }

                txtCodigoForn.Text = (textofinal + txtCodigoForn.Text);
            }

        }
        public void AcrescenteZero_a_Esquerda_Centro()
        {
            string texto;
            string textofinal;
            int tamanho;
            textofinal = "";
            texto = txtCodigoCentroCusto.Text.ToString();
            if ((txtCodigoCentroCusto.Text.Length < 6))
            {
                tamanho = txtCodigoCentroCusto.Text.Length;
                for (int t = 1; (t <= (6 - tamanho)); t++)
                {
                    textofinal = (textofinal + "0");
                }

                txtCodigoCentroCusto.Text = (textofinal + txtCodigoCentroCusto.Text);
            }

        }
        private void FrmCadastroContasPagar_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGrid_Parcelas.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            row.Height = 17;
            row.MinimumHeight = 17;

            if (StatusOperacao == "ALTERAR")
            {
                AcrescenteZero_a_Esquerda();
                return;
            }
            if (StatusOperacao == "NOVO")
            {
                txtDataEmissao.Text = DateTime.Now.ToShortDateString();
                txtVencimento.Text = DateTime.Now.ToShortDateString();

                IdCentroCusto = RetornaCodigoContaMaisUm(QueryCentro);

                IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));
                txtCodigo.Text = RetornaCodigoContaMaisUm(QueryContas).ToString();    

                AcrescenteZero_a_Esquerda();
                txtCodigoForn.Focus();
                txtCodigoForn.Select();
            }  
           
        }
        private void GravarConta()
        {

            IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));
            txtCodigo.Text = RetornaCodigoContaMaisUm(QueryContas).ToString();
            ContasMODEL objetocontas = new ContasMODEL();

            objetocontas.IDConta = Convert.ToInt32(IdConta);
            objetocontas.Datacadastro = Convert.ToDateTime(txtDataEmissao.Text);
            objetocontas.IDFornecedor = IdFornecedor;
            objetocontas.Descricao = txtDescricao.Text;
            objetocontas.IdcentroCusto = IdCentroCusto;

            ContasBLL contasbll = new ContasBLL();

            contasbll.gravaContasDal(objetocontas);
            //try
            //{
            //    IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));
            //    txtCodigo.Text = RetornaCodigoContaMaisUm(QueryContas).ToString();
            //    ContasMODEL objetocontas = new ContasMODEL();

            //    objetocontas.IDConta = Convert.ToInt32(IdConta);
            //    objetocontas.Datacadastro = Convert.ToDateTime(txtDataEmissao.Text);
            //    objetocontas.IDFornecedor = IdFornecedor;
            //    objetocontas.Descricao = txtDescricao.Text;
            //    objetocontas.IdcentroCusto = IdCentroCusto;
            //    ContasBLL contasbll = new ContasBLL();

            //    contasbll.gravaContasDal(objetocontas);
            //}
            //catch
            //{
            //    //MessageBox.Show("REGISTRO gravado com sucesso!"+ EX, "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
        }
        private void gravar_Parcelas()
        {

            foreach (DataGridViewRow linha in dataGrid_Parcelas.Rows)
            {
                var conn = Conexao.Conex(); int posicao = 0;
                SqlCeCommand cmd = new SqlCeCommand("INSERT INTO parcelas (idparcela, idconta, num_parcela, datavenc, valor_parc, pago) VALUES (@idparcela, @idconta, @num_parcela, @datavenc, @valor_parc, @pago)", conn);
                posicao = linha.Index;
                conn.Open();

                IdConta = Convert.ToInt32(linha.Cells[0].Value.ToString());
                IdParcela = Convert.ToInt32(linha.Cells[1].Value.ToString());
                Parcela = linha.Cells[2].Value.ToString();
                Datas = Convert.ToDateTime(linha.Cells[3].Value.ToString());
                Valor = Convert.ToDouble(linha.Cells[4].Value.ToString());

                string ValorR = Valor.ToString();
                IdParcela = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryParcela).ToString());
                Statusconta = false;
                Valor = Convert.ToDouble(ValorR.Replace("R", "").Replace("$", "").Replace(" ", "").Replace(".", ""));

                cmd.Parameters.AddWithValue("@idparcela", IdParcela);
                cmd.Parameters.AddWithValue("@idconta", IdConta);
                cmd.Parameters.AddWithValue("@num_parcela", Parcela);
                cmd.Parameters.AddWithValue("@datavenc", Datas);
                cmd.Parameters.AddWithValue("@valor_parc", Convert.ToDecimal(Valor));
                cmd.Parameters.AddWithValue("@pago", Statusconta);
            

                cmd.ExecuteNonQuery();               
                conn.Close();
            }
            MessageBox.Show("Registro gravado!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            LimpaVariáveis();
            txtCodigoForn.Select();
            LimpaCampo();
            txtDocument.Text = "0000";
            txtParcelas.Text = "1";
            txtDataEmissao.Text = DateTime.Now.ToShortDateString();
            txtVencimento.Text = DateTime.Now.ToShortDateString();

            IdCentroCusto = RetornaCodigoContaMaisUm(QueryCentro);

            IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas));
            txtCodigo.Text = RetornaCodigoContaMaisUm(QueryContas).ToString();

            AcrescenteZero_a_Esquerda();
        }
        public void LimpaVariáveis()
        {
            IdReceita = 0;
            IdFornecedor = 0;
            IdConta = 0;
            IdParcela = 0;
            Parcela = "";
            Valor = 0;
        }
        public void limparCelulasDatagrid()
        {
            //dataGrid_Parcelas.Rows.Clear();
            if (dataGrid_Parcelas.DataSource != null)
            {
                dataGrid_Parcelas.DataSource = null;
                dataGrid_Parcelas.AutoGenerateColumns = false;
            }

        }
        private void AlterarParcela()
        {
            AlterarConta();

            if (IdParcela != 0 && IdConta != 0)
            {
                ParcelaModel parcelaModel = new ParcelaModel();

                string valorParcela; valorParcela = txtValor.Text; valorParcela = valorParcela.Replace("R$", "").Replace(" ", "");

                parcelaModel.Numparcela = txtDocument.Text;
                parcelaModel.Valor_parc = Convert.ToDecimal(valorParcela);
                parcelaModel.Datavenc = Convert.ToDateTime(txtVencimento.Text);
                parcelaModel.Idparcela = Convert.ToInt32(IdParcela);

                ParcelaBLL parcelabll = new ParcelaBLL();
                parcelabll.atualiza_parcelas(parcelaModel);
                MessageBox.Show("Registro Alterado com sucesso!", "Informe!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LimpaCampo();
            }
        }
        private void AlterarConta()
        {
            Frm_Manut_Avancado manut = new Frm_Manut_Avancado();
            try
            {
                if (IdConta != 0)
                {
                    ContasMODEL ContasModel = new ContasMODEL();

                    ContasModel.IDFornecedor = IdFornecedor;
                    ContasModel.Descricao = txtDescricao.Text;
                    ContasModel.IDConta = Convert.ToInt32(IdConta);

                    ContasBLL contasbll = new ContasBLL();
                    contasbll.atualiza_conta2(ContasModel);
                }
                else
                    MessageBox.Show("Localize novamente o fornecedor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
            }
            manut.Executa_Somas();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AlterarParcela();
            }
            if (StatusOperacao == "NOVO")
            {
                if (IdFornecedor != 0 & IdCentroCusto != 0)
                {
                    GravarConta();
                    gravar_Parcelas();
                    limparCelulasDatagrid();
                }
            }

            //((Frm_Manut_Avancado)Application.OpenForms["Frm_Manut_Avancado"]).HabilitarTimer(true);// Habilita Timer do outro form Obs: O timer no outro form executa um Método.        
        }

        private void txtCodigoForn_Leave(object sender, EventArgs e)
        {
            Comm = new SqlCeCommand("Select fornecedor From fornecedor WHERE idfornecedor = @idfornecedor");
            Comm.Parameters.AddWithValue("@idfornecedor", txtCodigoForn.Text);

            try
            {
                txtFavorecido.Text = LocalizarFornecedor(Comm).Rows[0]["fornecedor"].ToString();
                
                IdFornecedor = Convert.ToInt32(txtCodigoForn.Text);
                txtCodigoCentroCusto.Focus();
            }
            catch
            {
                //MessageBox.Show("Digite um código válido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoForn.Text = "";                
            }
            txtCodigoForn.BackColor = Color.OldLace;
            AcrescenteZero_a_Esquerda_Forn();
        }

        private void txtCodigoCentroCusto_Leave(object sender, EventArgs e)
        {
            Comm = new SqlCeCommand("Select centrocusto From centrocusto WHERE idcentrocusto = @idcentro");
            Comm.Parameters.AddWithValue("@idcentro", txtCodigoCentroCusto.Text);

            try
            {
                txtCentroCusto.Text = LocalizarFornecedor(Comm).Rows[0]["centrocusto"].ToString();  
                IdCentroCusto = Convert.ToInt32(txtCodigoCentroCusto.Text);
                txtDescricao.Focus();
            }
            catch
            {
                //MessageBox.Show("Digite um código válido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoCentroCusto.Text = "";                
            }
            txtCodigoCentroCusto.BackColor = Color.OldLace;
            AcrescenteZero_a_Esquerda_Centro();
        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {
            Frm_Pesquisa_Fornecedor pesquisacli = new Frm_Pesquisa_Fornecedor();
            pesquisacli.ShowDialog();


            IdFornecedor = pesquisacli.IdFornecedor;
            txtCodigoForn.Text = pesquisacli.IdFornecedor.ToString();
            txtFavorecido.Text = pesquisacli.Fornecedor;
            txtCodigoCentroCusto.Select();
            AcrescenteZero_a_Esquerda_Forn();            
        }

        private void btnLocalizarCentro_Click(object sender, EventArgs e)
        {
            Frm_Pesquisa_Centro pesqcentro = new Frm_Pesquisa_Centro();
            pesqcentro.ShowDialog();
            IdCentroCusto = pesqcentro.IdCentro;
            
            txtCodigoCentroCusto.Text = pesqcentro.IdCentro.ToString();
            txtCentroCusto.Text = pesqcentro.CentroCusto;
            
            txtDescricao.Select();
            AcrescenteZero_a_Esquerda_Centro();
        }

        private void txtCodigoForn_Enter(object sender, EventArgs e)
        {
            txtCodigoForn.BackColor = Color.Yellow;
        }

        private void txtFavorecido_Enter(object sender, EventArgs e)
        {
            txtFavorecido.BackColor = Color.Yellow;
        }

        private void txtCentroCusto_Enter(object sender, EventArgs e)
        {
            txtCentroCusto.BackColor = Color.Yellow;
        }

        private void txtFavorecido_Leave(object sender, EventArgs e)
        {
            txtFavorecido.BackColor = Color.OldLace;
        }

        private void txtCentroCusto_Leave(object sender, EventArgs e)
        {
            txtCentroCusto.BackColor = Color.OldLace;
        }

        private void txtValorTotal_KeyUp(object sender, KeyEventArgs e)
        {
            string valorsemformato;
            valorsemformato = txtValorTotal.Text;
            valorsemformato = valorsemformato.Replace("R$", "").Replace(" ", "");
            txtValorTotal.Text = valorsemformato;
        }

        private void txtValorTotal_Click(object sender, EventArgs e)
        {
            string valorsemformato;
            valorsemformato = txtValorTotal.Text;
            valorsemformato = valorsemformato.Replace("R$", "").Replace(" ", "");
            txtValorTotal.Text = valorsemformato;
        }
        public void AcrescenteZero_a_Esquerda2()
        {
            //dataGrid_Parcelas.Columns[1].DefaultCellStyle.Format = "000000";           
        }
        private void GerarParcelas()
        {
            try
            {
                if (txtValorTotal.Text != string.Empty & txtVencimento.Text != string.Empty)
                {
                    IdConta = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryContas).ToString());
                    IdParcela = Convert.ToInt16(RetornaCodigoContaMaisUm(QueryParcela).ToString());
                    string valorsemformato;
                    valorsemformato = txtValorTotal.Text;
                    valorsemformato = valorsemformato.Replace("R$", "").Replace(".", "");

                    //testando com as parcelas
                    Int32 Num_Parcela = Convert.ToInt32(txtParcelas.Text);
                    double Total = Convert.ToDouble(valorsemformato);
                    Datas = Convert.ToDateTime(txtVencimento.Text);
                    Double ValorParcela = Total / Num_Parcela;
                    DataTable dt = new DataTable();

                    dt.Columns.Add("idconta", typeof(int));
                    dt.Columns.Add("idparcela", typeof(int));
                    dt.Columns.Add("num_parcela");
                    dt.Columns.Add("datavenc", typeof(DateTime));
                    dt.Columns.Add("valor_parc", typeof(Double));

                    var Idparcela = Convert.ToInt32(IdParcela);

                    for (var i = 0; i < Num_Parcela; i++)
                    {
                        dt.Rows.Add(IdConta, Idparcela++, (txtDocument.Text + "-" + (i + 1 + "/" + +(Num_Parcela))), Datas.AddMonths(i), ValorParcela);
                        //dt.Rows.Add(IdConta, Idparcela++, (txtDocument.Text + "-" + (i + 1 + "/" + +(Num_Parcela))), Datas.AddMonths(i), ValorParcela);
                    }
                    dataGrid_Parcelas.DataSource = dt;
                    //**************************************************GAMBIARRA**************************************************
                    //foreach (DataGridViewRow row in dataGrid_Parcelas.Rows)
                    //{
                    //    foreach (DataGridViewCell cell in row.Cells)
                    //    {
                    //        if (cell.ColumnIndex == dataGrid_Parcelas.Columns[4].Index)
                    //        {
                    //            cell.Style.Format = "N";
                    //        }
                    //    }
                    //}
                    Formata_Grid_Parcelas();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possivel gerar parcelas", "Informe Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AcrescenteZero_a_Esquerda2();
        }
        public void Formata_Grid_Parcelas()
        {
            dataGrid_Parcelas.AutoGenerateColumns = false;
        }
        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            if (txtVencimento.Text != "")
            {


            }
            txtValorTotal.BackColor = Color.OldLace;
            if (txtValorTotal.Text != "" & txtVencimento.Text != string.Empty )
            {
                txtValorTotal.Text = Convert.ToDouble(txtValorTotal.Text).ToString("C");
                //********************************************
                string preco = Convert.ToString(txtValorTotal.Text);
                preco = preco.Replace("R", "").Replace("$", "").Replace(" ", "").Replace(".", "").ToString();

                ValorParcela = Convert.ToDouble(preco);
                NumParcela = Convert.ToInt32(txtParcelas.Text);

                ValorTotal = ValorParcela / NumParcela;
                txtValor.Text = ValorTotal.ToString("C");


                //GerarParcelas();               
            }
        }
        public void CalcularParcela()
        {
            if (txtValorTotal.Text != string.Empty)
            {
                string preco = Convert.ToString(txtValorTotal.Text);
                preco = preco.Replace("R", "").Replace("$", "").Replace(" ", "").Replace(".", "").ToString();


                ValorParcela = Convert.ToDouble(preco);
                NumParcela = Convert.ToInt32(txtParcelas.Text);
                ValorTotal = ValorParcela / NumParcela;
                txtValor.Text = ValorTotal.ToString("C");
            }
        }
        private void checkBoxGerarParcelas_Click(object sender, EventArgs e)
        {           
        }

        private void NumUpDow_Parcela_SelectedItemChanged(object sender, EventArgs e)
        {
            //if (txtValorTotal.Text != string.Empty & txtVencimento.Text != string.Empty )
            //{
            //    CalcularParcela();
            //    GerarParcelas();
            //}
        }

        private void NumUpDow_Parcela_TextChanged(object sender, EventArgs e)
        {
            //if (txtValorTotal.Text != string.Empty & txtVencimento.Text != string.Empty)
            //{
            //    if (txtValorTotal.Text != string.Empty & txtVencimento.Text != string.Empty)
            //    {
            //        GerarParcelas();
            //    }   
            //}   
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.OldLace;
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.Yellow;
        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            txtValorTotal.BackColor = Color.Yellow;
        }

        private void txtDocument_Leave(object sender, EventArgs e)
        {
            txtDocument.BackColor = Color.OldLace;
        }

        private void txtDocument_Enter(object sender, EventArgs e)
        {
            txtDocument.BackColor = Color.Yellow;
        }

      
        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarParcelas();
        }

        private void txtDataEmissao_Enter(object sender, EventArgs e)
        {
            txtDataEmissao.BackColor = Color.Yellow;
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            txtDataEmissao.BackColor = Color.OldLace;
        }

        private void txtCodigoCentroCusto_Enter(object sender, EventArgs e)
        {
            txtCodigoCentroCusto.BackColor = Color.Yellow;
        }

        private void txtParcelas_Leave(object sender, EventArgs e)
        {
            txtParcelas.BackColor = Color.OldLace;
        }

        private void txtParcelas_Enter(object sender, EventArgs e)
        {
            txtParcelas.BackColor = Color.Yellow;
        }

        private void txtVencimento_Enter(object sender, EventArgs e)
        {
            txtVencimento.BackColor = Color.Yellow;
        }

        private void txtVencimento_Leave(object sender, EventArgs e)
        {
            txtVencimento.BackColor = Color.OldLace;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
