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
    public partial class FrmPesquisaGrupo : Money.FrmBaseGeral
    {
        public string Letra;

        public FrmPesquisaGrupo()
        {
            InitializeComponent();
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

        private void dataGridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregaDados();
        }
        public void ListarGrupos()
        {
            GrupoBLL grupobll = new GrupoBLL();
            dataGridPesquisa.DataSource = grupobll.ListaGrupo();
        }
        private void CarregaDados()
        {
            FrmCadastroGrupo f3 = new FrmCadastroGrupo();
            try
            {
                if (linhaAtual >= 0)
                {
                    f3.Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);                   
                    f3.txtGrupo.Text = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    Nome = dataGridPesquisa[1, linhaAtual].Value.ToString();
                    
                    f3.StatusOperacao = "ALTERAR";
                    f3.Text = "Alterar Marca : > " + Nome;

                    f3.ShowDialog();
                    ListarGrupos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro..." + ex.Message);
            }
        }
        public void Excluir()
        {
            try
            {
                Codigo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);
                Nome = dataGridPesquisa[1, linhaAtual].Value.ToString();


                if (MessageBox.Show("Deseja Excluir? \n\nNº  '" + Codigo + "    Grupo: " + Nome + " ", "Grupo: "+Nome+"", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    GrupoMODEL grupomodel = new GrupoMODEL();
                    grupomodel.Idgrupo = Convert.ToInt32(dataGridPesquisa[0, linhaAtual].Value);

                    GrupoBLL grupobll = new GrupoBLL();
                    grupobll.Excluir(grupomodel);
                    MessageBox.Show("REGISTRO EXCLUÍDO!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ListarGrupos();
                }
            }
            catch
            {
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastroGrupo cadgru = new FrmCadastroGrupo();
            cadgru.StatusOperacao = "NOVO";
            cadgru.ShowDialog();
            ListarGrupos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    ListarGrupos();
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally { conn.Close(); }
        }

        //public void LocalizarNovo(string Pesquisa)
        //{
        //    Frm_Base_Pesquisa pesquisa = new Frm_Base_Pesquisa();
        //    var conn = Conexao.Conex();

        //    SqlCeCommand sqlStringNome = new SqlCeCommand("SELECT * FROM grupos  WHERE grupo LIKE @pesquisa", conn);
        //    sqlStringNome.Parameters.AddWithValue("@pesquisa", Nome + "%");
        //    try
        //    {
        //        conn.Open();
        //        System.Data.DataTable tabela = new System.Data.DataTable();
        //        SqlCeDataAdapter adapter = new SqlCeDataAdapter();
        //        adapter.SelectCommand = sqlStringNome;
        //        adapter.Fill(tabela);

        //        if (tabela.Rows.Count > 0)
        //        {
        //            dataGridPesquisa.DataSource = tabela;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Nenhum registro encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.Message.ToString();
        //    }
        //    finally { conn.Close(); }
        //}

        private void FrmPesquisaGrupo_Load(object sender, EventArgs e)
        {
            ListarGrupos();
        }
        public void Pesquisar22()
        {
                Frm_Base_Pesquisa pesquisa = new Frm_Base_Pesquisa();
                var conn = Conexao.Conex();

                SqlCeCommand sqlStringNome = new SqlCeCommand("SELECT * FROM grupos  WHERE grupo LIKE @pesquisa", conn);
                sqlStringNome.Parameters.AddWithValue("@pesquisa", Nome + "%");
                PesquisarLocal(sqlStringNome);
           
        }       
        private void FrmPesquisaGrupo_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode.ToString() =="F")
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

        private void FrmPesquisaGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Escape)
            //{
            //    return;
            //}
            //if (e.KeyChar == (char)Keys.B)
            //{
            //    Letra = "B";
            //}
            //if (e.KeyChar == (char)Keys.C)
            //{
            //    Letra = "C";
            //}
            //if (e.KeyChar == (char)Keys.D)
            //{
            //    Letra = "D";
            //}
            //if (e.KeyChar == (char)Keys.E)
            //{
            //    Letra = "E";
            //}
            //if (e.KeyChar == (char)Keys.F)
            //{
            //    Letra = "F";
            //}
            //if (e.KeyChar == (char)Keys.G)
            //{
            //    Letra = "G";
            //}
            //if (e.KeyChar == (char)Keys.H)
            //{
            //    Letra = "H";
            //}
            //if (e.KeyChar == (char)Keys.I)
            //{
            //    Letra = "I";
            //}
            //if (e.KeyChar == (char)Keys.J)
            //{
            //    Letra = "J";
            //}
            //if (e.KeyChar == (char)Keys.K)
            //{
            //    Letra = "K";
            //}
            //if (e.KeyChar == (char)Keys.L)
            //{
            //    Letra = "L";
            //}
            //if (e.KeyChar == (char)Keys.M)
            //{
            //    Letra = "M";
            //}
            //if (e.KeyChar == (char)Keys.N)
            //{
            //    Letra = "N";
            //}
            //if (e.KeyChar == (char)Keys.O)
            //{
            //    Letra = "O";
            //}
            //if (e.KeyChar == (char)Keys.P)
            //{
            //    Letra = "P";
            //}
            //if (e.KeyChar == (char)Keys.Q)
            //{
            //    Letra = "Q";
            //}
            //if (e.KeyChar == (char)Keys.R)
            //{
            //    Letra = "R";
            //}
            //if (e.KeyChar == (char)Keys.S)
            //{
            //    Letra = "S";
            //}
            //if (e.KeyChar == (char)Keys.T)
            //{
            //    Letra = "T";
            //}
            //if (e.KeyChar == (char)Keys.U)
            //{
            //    Letra = "U";
            //}
            //if (e.KeyChar == (char)Keys.V)
            //{
            //    Letra = "V";
            //}
            //if (e.KeyChar == (char)Keys.X)
            //{
            //    Letra = "X";
            //}
            //if (e.KeyChar == (char)Keys.Z)
            //{
            //    Letra = "Z";
            //}
            //FrmLocalizaGrupo localizagrupo = new FrmLocalizaGrupo();
            //localizagrupo.Capturavalor = Letra;
            //localizagrupo.ShowDialog();

            //Nome = localizagrupo.txtGrupo.Text;
            //Pesquisar22();
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarGrupos();
            timer1.Enabled = false;
        }
    }
}
