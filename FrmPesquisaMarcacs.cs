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
    public partial class FrmPesquisaMarcacs : Money.FrmBaseGeral
    {
        public string Letra;
        public FrmPesquisaMarcacs()
        {
            InitializeComponent();
        }
        public void ListaMarcas()
        {
            MarcaBLL marcabll = new MarcaBLL();
            dataGridPesquisa.DataSource = marcabll.ListaMarcas();
        }
        private void FrmPesquisaMarcacs_Load(object sender, EventArgs e)
        {
           
            DataGridViewRow row = this.dataGridPesquisa.RowTemplate;
            //row.DefaultCellStyle.BackColor = Color.Bisque;
            row.Height = 17;
            row.MinimumHeight = 17;
            ListaMarcas();
        }

        private void dataGridPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                linhaAtual = int.Parse(e.RowIndex.ToString());
            }
            catch
            {
            }     
        }

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }

        private void dataGridPesquisa_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                linhaAtual = dataGridPesquisa.CurrentRow.Index;
            }
            catch
            {
            }   
        }
        private void CarregaDados()
        {
            FrmCadastroMarcas f3 = new FrmCadastroMarcas();
            try
            {
                if (linhaAtual >= 0)
                {                    
                    f3.Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                    f3.Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value); Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                    f3.txtMarca.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    Nome = dataGridPesquisa[1, linhaAtual].Value.ToString();

                 
                    f3.StatusOperacao = "ALTERAR";
                    f3.Text = "Alterar Marca : > " + Nome;

                    f3.ShowDialog();
                    ListaMarcas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroMarcas cadmarca = new FrmCadastroMarcas();
            cadmarca.StatusOperacao = "NOVO";
            cadmarca.ShowDialog();
            ListaMarcas();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }
       
        public void Excluir()
        {
            try
            {
                Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                Nome = dataGridPesquisa[1, linhaAtual].Value.ToString();
                

                if (MessageBox.Show("Deseja Excluir? \n\nNº  '" + Codigo + "    Marca: " + Nome + " ", "Marca: "+Nome+"", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MarcaMODEL marcasmodel = new MarcaMODEL();
                    marcasmodel.Idmarca = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);

                    MarcaBLL marcabll = new MarcaBLL();
                    marcabll.Excluir(marcasmodel);
                    MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ListaMarcas();
                }
            }
            catch
            {
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPesquisaMarcacs_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode.ToString() == "F12")
            //{
            //    e.Handled = true;
            //    //btnTeste.Visible = !btnTeste.Visible;
            //}
            if (e.KeyCode.ToString() == "A")
            {
                e.Handled = true;
                Letra = "A";
            }
            if (e.KeyCode.ToString() == "B")
            {
                e.Handled = true;
                Letra = "B";
            }
            if (e.KeyCode.ToString() == "C")
            {
                e.Handled = true;
                Letra = "C";
            }
            if (e.KeyCode.ToString() == "D")
            {
                e.Handled = true;
                Letra = "D";
            }
            if (e.KeyCode.ToString() == "E")
            {
                e.Handled = true;
                Letra = "E";
            }
            if (e.KeyCode.ToString() == "F")
            {
                e.Handled = true;
                Letra = "F";
            }
            if (e.KeyCode.ToString() == "G")
            {
                e.Handled = true;
                Letra = "G";
            }
            if (e.KeyCode.ToString() == "H")
            {
                e.Handled = true;
                Letra = "H";
            }
            if (e.KeyCode.ToString() == "I")
            {
                e.Handled = true;
                Letra = "I";
            }
            if (e.KeyCode.ToString() == "J")
            {
                e.Handled = true;
                Letra = "J";
            }
            if (e.KeyCode.ToString() == "K")
            {
                e.Handled = true;
                Letra = "K";
            }
            if (e.KeyCode.ToString() == "L")
            {
                e.Handled = true;
                Letra = "L";
            }
            if (e.KeyCode.ToString() == "M")
            {
                e.Handled = true;
                Letra = "M";
            }
            if (e.KeyCode.ToString() == "N")
            {
                e.Handled = true;
                Letra = "N";
            }
            if (e.KeyCode.ToString() == "O")
            {
                e.Handled = true;
                Letra = "O";
            }
            if (e.KeyCode.ToString() == "P")
            {
                e.Handled = true;
                Letra = "P";
            }
            if (e.KeyCode.ToString() == "Q")
            {
                e.Handled = true;
                Letra = "Q";
            }
            if (e.KeyCode.ToString() == "R")
            {
                e.Handled = true;
                Letra = "R";
            }
            if (e.KeyCode.ToString() == "S")
            {
                e.Handled = true;
                Letra = "S";
            }
            if (e.KeyCode.ToString() == "T")
            {
                e.Handled = true;
                Letra = "T";
            }
            if (e.KeyCode.ToString() == "U")
            {
                e.Handled = true;
                Letra = "U";
            }
            if (e.KeyCode.ToString() == "V")
            {
                e.Handled = true;
                Letra = "V";
            }
            if (e.KeyCode.ToString() == "X")
            {
                e.Handled = true;
                Letra = "X";
            }
            if (e.KeyCode.ToString() == "Z")
            {
                e.Handled = true;
                Letra = "Z";
            }
            FrmLocalizaGrupo localizagrupo = new FrmLocalizaGrupo();
            localizagrupo.Capturavalor = Letra;
            localizagrupo.ShowDialog();

            Nome = localizagrupo.txtGrupo.Text;
            Pesquisar22();
        }
        public void Pesquisar22()
        {
            Frm_Base_Pesquisa pesquisa = new Frm_Base_Pesquisa();
            var conn = Conexao.Conex();

            SqlCeCommand sqlStringNome = new SqlCeCommand("SELECT * FROM marcas  WHERE marca LIKE @pesquisa", conn);
            sqlStringNome.Parameters.AddWithValue("@pesquisa", Nome + "%");
            PesquisarLocal(sqlStringNome);
        }
        public void PesquisarLocal(SqlCeCommand criterioSQL)
        {
            var conn = Conexao.Conex();
            criterioSQL.Connection = conn;
            try
            {
                conn.Open();
                System.Data.DataTable tabela = new System.Data.DataTable();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter();
                adapter.SelectCommand = criterioSQL;
                adapter.Fill(tabela);

                if (tabela.Rows.Count > 0)
                {
                    dataGridPesquisa.DataSource = tabela;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ListaMarcas();
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ListaMarcas();
            timer1.Enabled = false;
        }
    }
}
