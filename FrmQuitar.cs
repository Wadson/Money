using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Money
{
    public partial class FrmQuitar : FrmBaseGeral
    {
        public FrmQuitar(FrmManutContasPagar Form4)
        {
            InitializeComponent();
        }

        public string sqlString3;
        private void Pagar()
        {
            ValorParc = Convert.ToDecimal(txtValorPago.Text);
            ParcelaModel objetoparcela = new ParcelaModel();
            try
            {
                if (txtValorPago.Text != string.Empty)
                {
                    objetoparcela.Datapgto = Convert.ToDateTime(txtDtPgto.Text);
                    objetoparcela.Valorpago = ValorParc;
                    objetoparcela.Pago = 1;                   
                   
                    objetoparcela.Idparcela = Id_Parcela;                  

                    ParcelaBLL parcelabll = new ParcelaBLL();
                    parcelabll.BaixarParcelas(objetoparcela);

                    MessageBox.Show("Conta baixada com sucesso ! ", "Informação !)", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ((FrmManutContasPagar)Application.OpenForms["FrmManutContasPagar"]).HabilitarTimer(true);
                    this.Close();
                }
                else
                    MessageBox.Show("Digite o valor que foi pago só números e pontos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Não há contas a pagar selecionada. Localize um registro primeiro.", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CalcularDesconto()
        {
            try
            {
                double valor2, valorpago2;              
                valor2 = Convert.ToDouble(ReplaceValores(txtValor));

                valorpago2 = Convert.ToDouble(ReplaceValores(txtValorPago));
                txtDescontoJuros.Text = Convert.ToString(valor2 - valorpago2);
            }
            catch
            {
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {           
            Pagar();                
        }

        private void Frm_Quitar_Load(object sender, EventArgs e)
        {
            txtValor.Text = ValorParc.ToString();
            txtVencimento.Text = Dt_Vcto_Parc.ToString(); 

            txtValorPago.Text = txtValor.Text;

            if (txtValorPago.Text != string.Empty)
            {
                txtValorPago.Text = Convert.ToDouble(txtValorPago.Text).ToString("N");
            }
            if (txtValor.Text != string.Empty)
            {
                txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("N");
            }            
        }

        private void txtValorPago_KeyUp(object sender, KeyEventArgs e)
        {
            ReplaceValores(txtValorPago);
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            try
            {
                double Valor, ValorPago;                      
                Valor = Convert.ToDouble(ReplaceValores(txtValor));
                ValorPago = Convert.ToDouble(ReplaceValores(txtValorPago));   
                txtDescontoJuros.Text = Convert.ToString(Valor - ValorPago);
                txtDescontoJuros.Text = Convert.ToDecimal(txtDescontoJuros.Text).ToString("N");

               
                if (txtValorPago.Text != string.Empty)
                {
                    txtValorPago.Text = Convert.ToDouble(txtValorPago.Text).ToString("N");
                }
                txtValorPago.BackColor = Color.White;
            }
            catch
            {
            }            
        }

        private void txt_Valor_Pago_Click(object sender, EventArgs e)
        {            
            txtValorPago.Text = ReplaceValores(txtValorPago).ToString();
        }


     
        private void txtDescontoJuros_Leave(object sender, EventArgs e)
        {
            if (rbDesconto.Checked == true && txtDescontoJuros.Text != string.Empty)
            {
                ValorParc = Convert.ToDecimal(txtValor.Text);
                decimal descontojuros = Convert.ToDecimal(txtDescontoJuros.Text);

                ValorParc = ValorParc - descontojuros;
                txtDescontoJuros.ForeColor = Color.Blue;
                txtValorPago.Text = ValorParc.ToString();
            }
            if (rbJuros.Checked == true && txtDescontoJuros.Text != string.Empty)
            {
                ValorParc = Convert.ToDecimal(txtValor.Text);
                decimal descontojuros = Convert.ToDecimal(txtDescontoJuros.Text);

                ValorParc = ValorParc + descontojuros;
                txtDescontoJuros.ForeColor = Color.Red;
                txtValorPago.Text = ValorParc.ToString();
            }
        }

        private void rbDesconto_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDescontoJuros.Text != string.Empty)
            {
                ValorParc = Convert.ToDecimal(txtValor.Text);
                decimal descontojuros = Convert.ToDecimal(txtDescontoJuros.Text);

                ValorParc = ValorParc - descontojuros;
                txtDescontoJuros.ForeColor = Color.Blue;
                txtValorPago.Text = ValorParc.ToString();
            }
        }

        private void rbJuros_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDescontoJuros.Text != string.Empty)
            {
                ValorParc = Convert.ToDecimal(txtValor.Text);
                decimal descontojuros = Convert.ToDecimal(txtDescontoJuros.Text);

                ValorParc = ValorParc + descontojuros;
                txtDescontoJuros.ForeColor = Color.Red;
                txtValorPago.Text = ValorParc.ToString();
            }
        }
    }
}
