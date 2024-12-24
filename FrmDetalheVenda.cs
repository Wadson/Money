using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class FrmDetalheVenda : Money.FrmBaseGeral
    {
        public FrmDetalheVenda()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirVenda();
        }
        public void ExcluirVenda()
        {
            Id_Venda = Convert.ToInt32(txtCodVenda.Text);

            Cliente = txtNomeCliente.Text;
       
            if (MessageBox.Show("Excluir? Código: " + Cliente + " ", "Excluir Venda!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                //*************CONTASRECEBER**********************
                ContasReceberMODEL contasreceberMODEL = new ContasReceberMODEL();
                contasreceberMODEL.Id_contasreceber = Convert.ToInt32(Id_ContasReceber);

                ContasReceberBLL contasreceberbll = new ContasReceberBLL();
                contasreceberbll.exclui_Conta(contasreceberMODEL);

                //*************PARCELA****************************
                ParcelaModel parcelaMODEL = new ParcelaModel();
                parcelaMODEL.Idparcela = Convert.ToInt32(Id_Parcela);

                ParcelaBLL parcelabll = new ParcelaBLL();
                parcelabll.excluir_Todas_Parcelas(parcelaMODEL);

                //*************ITENS VENDA************************
                ItensVendaMODEL istensvendaMODEL = new ItensVendaMODEL();
                istensvendaMODEL.Id_itensvenda = Convert.ToInt32(Id_Itensvenda);

                ItensVendaBLL itensvendabll = new ItensVendaBLL();
                itensvendabll.ExcluirItensVenda(istensvendaMODEL);

                //***********VENDA********************************
                VendaMODEL fvendaMODEL = new VendaMODEL();
                fvendaMODEL.Id_venda = Convert.ToInt32(Id_Venda);

                VendaBLL vendabll = new VendaBLL();
                vendabll.ExcluirVenda(fvendaMODEL);

                MessageBox.Show("Conta a Receber Excluída com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((frmManutContasReceber)Application.OpenForms["frmManutContasReceber"]).HabilitarTimer(true);                
            }

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "ALTERAR")
            {
                //AlterarRegistro();
                ((FrmManutCliente)Application.OpenForms["FrmManutCliente"]).HabilitarTimer(true);
            }
            if (StatusOperacao == "EXCLUIR")
            {
                ExcluirVenda();
                ((FrmManutCliente)Application.OpenForms["FrmManutCliente"]).HabilitarTimer(true);
            }
        }
    }
}
