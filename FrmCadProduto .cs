using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmCadProduto : FrmBaseGeral
    {
        //public string StatusOperacao;
        public FrmCadProduto()
        {
            InitializeComponent();
        }
        public void GravarRegistro()
        {            
            try
            {
                ProdutosMODEL objProduto = new ProdutosMODEL();

                objProduto.Id_produto = Convert.ToInt32(txtIdProduto.Text);
                objProduto.Nome_produto = txtProduto.Text;
                objProduto.Descricao_produto = txtDescricaoProduto.Text;
                objProduto.Marca_produto = txtMarcaProduto.Text;
                objProduto.Precocusto_produto = Convert.ToDouble(txtPrecoCustoProduto.Text);
                objProduto.Lucro_produto = Convert.ToDouble(txtLucroProduto.Text);
                objProduto.Precovenda_produto = Convert.ToDouble(txtPrecoVendaProduto.Text);

                ProdutoBLL produtobll = new ProdutoBLL();

                produtobll.Salvar(objProduto);
                MessageBox.Show("REGISTRO gravado com sucesso!", "Informação!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                frmManutProduto Form = new frmManutProduto();
                LimpaCampo();
                txtIdProduto.Text = RetornaCodigoContaMaisUm(QueryProduto).ToString();
                IdProduto = Convert.ToInt32(RetornaCodigoContaMaisUm(QueryProduto));

                
                txtProduto.Select();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao gravar O REGISTRO!!! " + erro);
            }            
        }
        public void AlterarRegistro()
        {
            try
            {
                ProdutosMODEL objProduto = new ProdutosMODEL();
              
                objProduto.Nome_produto = txtProduto.Text;
                objProduto.Descricao_produto = txtDescricaoProduto.Text;
                objProduto.Marca_produto = txtMarcaProduto.Text;
                objProduto.Precocusto_produto = Convert.ToDouble(txtPrecoCustoProduto.Text);
                objProduto.Lucro_produto = Convert.ToInt32(txtLucroProduto.Text);
                objProduto.Precovenda_produto = Convert.ToDouble(txtPrecoVendaProduto.Text);
                objProduto.Id_produto = Convert.ToInt32(txtIdProduto.Text);
                ProdutoBLL produtobll = new ProdutoBLL();

                produtobll.Alterar(objProduto);
                MessageBox.Show("Registro Alterado com sucesso!", "Alteração!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);               
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Alterar O REGISTRO!!! " + erro);
            }
        }
        public override string EvitarDuplicado(string Tabela, string Campo, string CampoParametro)
        {
            return base.EvitarDuplicado(Tabela, Campo, CampoParametro);
        }
        public void AcrescenteZero_a_Esquerda()
        {
            string texto;
            string textofinal;
            int tamanho;
            textofinal = "";
            texto = txtIdProduto.Text.ToString();
            if ((txtIdProduto.Text.Length < 10))
            {
                tamanho = txtIdProduto.Text.Length;
                for (int t = 1; (t <= (4 - tamanho)); t++)
                {
                    textofinal = (textofinal + "0");
                }
                txtIdProduto.Text = (textofinal + txtIdProduto.Text);
            }

            if ((txtIdProduto.Text == "0000"))
            {
                //MessageBox.Show("DEVE SER DIGITADO ALGUM VALOR NO CAMPO CÓDIGO.","INFORMAÇÃO !", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //txtCodForn.Text = "";
                //txtCodForn.Focus();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AlterarRegistro();
            }
            if (StatusOperacao == "NOVO")
            {
                EvitarDuplicado("produto", "nome_produto", txtProduto.Text);
                if (RetornoEvitaDuplicado == "0")
                {
                    GravarRegistro();
                }
                try
                {                    
                    ((frmManutProduto)Application.OpenForms["frmManutProduto"]).HabilitarTimer(true);
                }
                catch
                {
                }
            }
        } 
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProduto_Enter(object sender, EventArgs e)
        {
            txtProduto.BackColor = Color.Yellow;
        }

        private void txtProduto_Leave(object sender, EventArgs e)
        {
            txtProduto.BackColor = Color.White;
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            LimpaCampo();
            txtProduto.Focus();
        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                AcrescenteZero_a_Esquerda();
                txtLucroProduto.Text = Decimal.Parse(txtLucroProduto.Text).ToString("N2");
                txtPrecoCustoProduto.Text = Decimal.Parse(txtPrecoCustoProduto.Text).ToString("N2");
                txtPrecoVendaProduto.Text = Decimal.Parse(txtPrecoVendaProduto.Text).ToString("N2");
            }
            if (StatusOperacao == "NOVO")
            {
                IdProduto = RetornaCodigoContaMaisUm(QueryProduto);
                txtIdProduto.Text = RetornaCodigoContaMaisUm(QueryProduto).ToString();
                AcrescenteZero_a_Esquerda();
                txtProduto.Focus();
            }
        }

        private void txtDescricaoProduto_Enter(object sender, EventArgs e)
        {
            txtDescricaoProduto.BackColor = Color.Yellow;
        }

        private void txtDescricaoProduto_Leave(object sender, EventArgs e)
        {
            txtDescricaoProduto.BackColor = Color.White;
        }

        private void txtMarcaProduto_Leave(object sender, EventArgs e)
        {
            txtMarcaProduto.BackColor = Color.White;
        }

        private void txtMarcaProduto_Enter(object sender, EventArgs e)
        {
            txtMarcaProduto.BackColor = Color.Yellow;
        }
        public void ToMoney(System.Windows.Forms.TextBox text, string format = "N")
        {
            double value;
            if(text.Text != string.Empty)
            {
                if (double.TryParse(text.Text, out value))
                {
                    text.Text = value.ToString(format);
                }
                else
                {
                    text.Text = "0,00";
                }
            }           
        }
        private void CalculaPrecoVenda()
        {
            try
            {
                if (txtPrecoCustoProduto.Text != string.Empty && txtLucroProduto.Text != string.Empty)
                {
                    decimal precovenda;
                    decimal lucro = decimal.Parse(txtLucroProduto.Text);
                    decimal precocusto = decimal.Parse(txtPrecoCustoProduto.Text);

                    precovenda = precocusto + lucro;
                    txtPrecoVendaProduto.Text = precovenda.ToString();                   
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Atenção!", "Erro" + ex, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CalculaPrecoCusto()
        {
            try
            {
                if (txtPrecoCustoProduto.Text != string.Empty)
                {
                    decimal precovenda = Convert.ToDecimal(txtPrecoVendaProduto.Text);
                    decimal lucro;
                    decimal precocusto = Convert.ToDecimal( txtPrecoCustoProduto.Text);

                    lucro = precovenda - precocusto; 
                    txtLucroProduto.Text = lucro.ToString();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Atenção!", "Erro" + ex, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtPrecoCustoProduto_Leave(object sender, EventArgs e)
        {
            txtPrecoCustoProduto.BackColor = Color.White;   
            ToMoney(txtPrecoCustoProduto);
            if (txtLucroProduto.Text != string.Empty)
            {
                CalculaPrecoVenda();
            }
        }

        private void txtPrecoCustoProduto_Enter(object sender, EventArgs e)
        {
            txtPrecoCustoProduto.BackColor = Color.Yellow;
        }

        private void txtLucroProduto_Leave(object sender, EventArgs e)
        {
            txtLucroProduto.BackColor = Color.White;
            ToMoney(txtLucroProduto);
            CalculaPrecoVenda();
        }

        private void txtLucroProduto_Enter(object sender, EventArgs e)
        {
            txtLucroProduto.BackColor = Color.Yellow;
        }

        private void txtPrecoVendaProduto_Leave(object sender, EventArgs e)
        {
            txtPrecoVendaProduto.BackColor = Color.White;
            CalculaPrecoCusto();
            ToMoney(txtPrecoVendaProduto);
        }

        private void txtPrecoVendaProduto_Enter(object sender, EventArgs e)
        {
            txtPrecoVendaProduto.BackColor = Color.Yellow;
        }
    }
}
