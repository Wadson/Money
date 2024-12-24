using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Drawing.Drawing2D;

namespace Money
{
    public partial class FrmPesquisaContasAgrupado : Money.FrmBaseGeral
    {

        public FrmPesquisaContasAgrupado()
        {
            InitializeComponent();            
          
        }
       
        public void carregaGrid2(SqlCeCommand sQ)
        {
            var conn = Conexao.Conex();
            sQ.Connection = conn;
            try
            {
                conn.Open();

                System.Data.DataTable tabela = new System.Data.DataTable();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter();
                adapter.SelectCommand = sQ;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    datagrid_Pesquisa.DataSource = tabela;                  
                }
                else
                {                   
                    if (tabela.Rows.Count == 0)
                    {
                        datagrid_Pesquisa.DataSource = tabela;
                        // Obter o número de celulas da gridview
                        int columnSpan = datagrid_Pesquisa.Rows[0].Cells.Count;
                        // Apaga todo o conteudo da primeira linha
                        datagrid_Pesquisa.Rows[0].Cells.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }

        }
      
        private void FrmPesquisaContasAgrupado_Load(object sender, EventArgs e)
        {
            if(Status =="PAGAS")
            {
                 SqlCeCommand comando = new SqlCeCommand("SELECT fornecedor.fornecedor, COUNT(*) AS QTD_PARCELAS, SUM(parcelas.valor_parc) AS VALOR_TOTAL FROM contas INNER JOIN " +
                      " parcelas ON contas.idconta = parcelas.idconta INNER JOIN fornecedor ON contas.idfornecedor = fornecedor.idfornecedor WHERE pago = 1 GROUP BY fornecedor.fornecedor");

            carregaGrid2(comando); 
            }
            if(Status == "ABERTAS")
            {
                 SqlCeCommand comando = new SqlCeCommand("SELECT fornecedor.fornecedor, COUNT(*) AS QTD_PARCELAS, SUM(parcelas.valor_parc) AS VALOR_TOTAL FROM contas INNER JOIN " +
                      " parcelas ON contas.idconta = parcelas.idconta INNER JOIN fornecedor ON contas.idfornecedor = fornecedor.idfornecedor WHERE pago = 0 GROUP BY fornecedor.fornecedor");

            carregaGrid2(comando); 
            }
            
            
            
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
