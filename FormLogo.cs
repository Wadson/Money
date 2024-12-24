using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Money
{
    public partial class FormLogo : Form
    {
        public FormLogo()
        {
            InitializeComponent();
        }
        public string sqlString_a_vencer, sqlString_vencidos, sqlString_Total, sqlString_Vence_Hoje, sqlString_Mes = "";
        public string sqlString, sqlString2, sqlString3, criterio = "";

        private void lblVencHoje_Click(object sender, EventArgs e)
        {
            //FrmManutContasPagar manucontapagar = new FrmManutContasPagar();
            //manucontapagar.Criterio = "VENCEHOJE";
            //manucontapagar.ShowDialog();
            //Somar();
        }

        private void lbl_Total_Geral_Click(object sender, EventArgs e)
        {
            //FrmManutContasPagar manucontapagar = new FrmManutContasPagar();
            //manucontapagar.Criterio = "TODOS";
            //manucontapagar.ShowDialog();
            //Somar();
        }

        private void lbl_a_Vencer_Click(object sender, EventArgs e)
        {
            //FrmManutContasPagar manucontapagar = new FrmManutContasPagar();
            //manucontapagar.Criterio = "AVENCER";
            //manucontapagar.ShowDialog();
            //Somar();
        }

        private void lbl_Vencdos_Click(object sender, EventArgs e)
        {
            //FrmManutContasPagar manucontapagar = new FrmManutContasPagar();
            //manucontapagar.Criterio = "VENCIDOS";
            //manucontapagar.ShowDialog();
            //Somar();
        }

        //public void Somar()
        //{
        //    somar_Vencidos();
        //    somar_a_Vencer();
        //    somar_Vence_Hoje();
        //    somar_Total();
        //}
        private void FormLogo_Load(object sender, EventArgs e)
        {
            //Somar();
        }

        //public void somar_a_Vencer()
        //{
        //    var conn = Conexao.Conex();
        //    sqlString_a_vencer = "SELECT SUM(valor_parc) FROM parcelas WHERE dt_vcto_parcela > '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' AND pago = 0 ";
        //    SqlCommand comm_a_vencer = new SqlCommand(sqlString_a_vencer, conn);
        //    conn.Open();
        //    string retorno;

        //    if (comm_a_vencer != null)
        //    {
        //        retorno = comm_a_vencer.ExecuteScalar().ToString();
        //        double total_a_vencer = string.IsNullOrEmpty(retorno) ? 0 : double.Parse(retorno);
        //        lbl_a_Vencer.Text = total_a_vencer.ToString("N");
        //    }
        //    else
        //        lbl_a_Vencer.Text = "0,00";
        //    conn.Close();
        //    try
        //    {
               
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show("Erro ao conectar ao banco de dados \r\r\r" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //public void somar_Vence_Hoje()
        //{
        //    try
        //    {
        //        var conn = Conexao.Conex();
        //        sqlString_Vence_Hoje = "SELECT SUM(valor_parc) FROM parcelas WHERE dt_vcto_parcela = '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' AND pago = 0 ";
        //        SqlCommand comm_a_vencer = new SqlCommand(sqlString_Vence_Hoje, conn);
        //        conn.Open();
        //        string retorno;

        //        if (comm_a_vencer != null)
        //        {
        //            retorno = comm_a_vencer.ExecuteScalar().ToString();
        //            double total_Vence_Hoje = string.IsNullOrEmpty(retorno) ? 0 : double.Parse(retorno);                  
        //            lblVencHoje.Text = total_Vence_Hoje.ToString("N");
        //        }
        //        else
        //            lblVencHoje.Text = "0,00";
        //        conn.Close();
        //    }
        //    catch
        //    {
        //    }
        //}
        //public void somar_Vencidos()
        //{
        //    try
        //    {
        //        var conn = Conexao.Conex();
        //        sqlString_vencidos = "SELECT SUM(valor_parc) FROM parcelas WHERE dt_vcto_parcela < '" + DateTime.Now.ToString("yyyy-MM-dd 00:00:00") + "' AND pago = 0 ";
        //        SqlCommand comm_vencidos = new SqlCommand(sqlString_vencidos, conn);
        //        conn.Open();
        //        string retorno;
        //        if (comm_vencidos != null)
        //        {
        //            retorno = comm_vencidos.ExecuteScalar().ToString();
        //            double total_vencido = string.IsNullOrEmpty(retorno) ? 0 : double.Parse(retorno);                 
        //            lbl_Vencdos.Text = total_vencido.ToString("N");
        //        }
        //        else
        //            lbl_Vencdos.Text = "0,00";
        //        conn.Close();
        //    }
        //    catch
        //    {
        //    }
        //}
        //public void somar_Total()
        //{
        //    try
        //    {
        //        var conn = Conexao.Conex();
        //        sqlString_Total = "SELECT SUM(valor_parc) FROM parcelas WHERE pago = 0";
        //        SqlCommand comm_total = new SqlCommand(sqlString_Total, conn);
        //        conn.Open();
        //        string retorno;
        //        if (comm_total != null)
        //        {
        //            retorno = comm_total.ExecuteScalar().ToString();
        //            double total = string.IsNullOrEmpty(retorno) ? 0 : double.Parse(retorno);                   
        //            lbl_Total_Geral.Text = total.ToString("N");
        //        }
        //        else
        //            lbl_Total_Geral.Text = "0,00";
        //        conn.Close();
        //    }
        //    catch
        //    {
        //    }
        //}
    }
}
