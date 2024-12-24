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
    public partial class FrmPesquisaContasPagar : Money.FrmBaseGeral
    {
        private SqlCeCommand strSQL;       

        public FrmPesquisaContasPagar()
        {
            InitializeComponent();
        }
        public void AcrescenteZero_a_Esquerda()
        {
            string texto;
            string textofinal;
            int tamanho;
            textofinal = "";
            texto = txtCodForn.Text.ToString();
            if ((txtCodForn.Text.Length < 10))
            {
                tamanho = txtCodForn.Text.Length;
                for (int t = 1; (t <= (4 - tamanho)); t++)
                {
                    textofinal = (textofinal + "0");
                }

                txtCodForn.Text = (textofinal + txtCodForn.Text);
            }

            if ((txtCodForn.Text == "0000"))
            {
                //MessageBox.Show("DEVE SER DIGITADO ALGUM VALOR NO CAMPO CÓDIGO.","INFORMAÇÃO !", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //txtCodForn.Text = "";
                //txtCodForn.Focus();
            }
        }
        private void txtCodForn_Leave(object sender, EventArgs e)
        {
            strSQL = new SqlCeCommand("Select fornecedor From fornecedor WHERE idfornecedor = @idfornecedor");
            strSQL.Parameters.AddWithValue("@idfornecedor", txtCodForn.Text);

            try
            {  
                txtFornecedor.Text = LocalizarFornecedor(strSQL).Rows[0]["fornecedor"].ToString();
                AcrescenteZero_a_Esquerda();
            }
            catch
            {
                MessageBox.Show("Digite outro código","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtCodForn.Text = ""; txtCodForn.Focus();
            }
            
        }

        private void btnLocalizarFornecedor_Click(object sender, EventArgs e)
        {           
            FrmPesquisaCadastroFornecedor pesqfor = new FrmPesquisaCadastroFornecedor();
            pesqfor.Capturavalor = txtFornecedor.Text;
            pesqfor.Qtd_caractere = this.txtFornecedor.TextLength;

            pesqfor.ShowDialog();
           

            IdFornecedor = pesqfor.IdFornecedor;
            txtCodForn.Text = pesqfor.IdFornecedor.ToString();
            AcrescenteZero_a_Esquerda();
            txtFornecedor.Text = pesqfor.Fornecedor;
            txtFornecedor.Select();
        }

        //public DataTable LocalizarFornecedor(SqlCeCommand comando)
        //{
        //    var conn = Conexao.Conex();
        //    comando.Connection = conn;
        //    try
        //    {
        //        conn.Open();
        //        SqlCeDataAdapter daCliente = new SqlCeDataAdapter();
        //        daCliente.SelectCommand = comando;
        //        DataTable dtFornecedor = new DataTable();
        //        daCliente.Fill(dtFornecedor);

        //        return dtFornecedor;
        //    }
        //    catch (Exception erro)
        //    {
        //        throw erro;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}       
      
        private void FrmPesquisaContasPagar_Load(object sender, EventArgs e)
        {           
            txtDataInicial.Text =  DateTime.Now.ToShortDateString();
            txtDataFinal.Text = DateTime.Now.ToShortDateString();
        }

      
    }
}
