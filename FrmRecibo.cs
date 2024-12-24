using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Money
{
    public partial class FrmRecibo :FrmBaseGeral
    {
        public FrmRecibo()
        {
            InitializeComponent();
        }

        private void btnGerarRecibo_Click(object sender, EventArgs e)
        {
            if (txt_cpf.Text != string.Empty && txt_emissor.Text != string.Empty && txt_extenso.Text != string.Empty && txt_favorecido.Text != string.Empty)
            {
                //instâncio a classe
                var wordFill = new WordFill();
                //chamo o método e passo os parâmetros            
                wordFill.PreencherPorReplace(Application.StartupPath + "\\Exemplo.docx", txt_favorecido.Text, txtValor.Text, txtValor.Text, txtReferente.Text, dtData.Value, txt_emissor.Text, txt_cpf.Text, txt_extenso.Text);
            }
        }

        private void frmRecibo_Load(object sender, EventArgs e)
        {          
            txt_favorecido.Select();
        }       
        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimpaCampo(); txt_favorecido.Focus();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.BackColor = Color.White;
            if (txtValor.Text != string.Empty)
            {
                try
                {
                    txt_extenso.Text = Converter.toExtenso(Convert.ToDecimal(txtValor.Text.Replace("R$", "").Replace(" ", "")));
                    txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("C");
                }
                catch
                {
                    lbl_erro.Text = "Digite um valor monetário!";
                }
            }  
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
        }

        private void txt_favorecido_Leave(object sender, EventArgs e)
        {
            txt_favorecido.BackColor = Color.White;
        }

        private void txt_favorecido_Enter(object sender, EventArgs e)
        {
            txt_favorecido.BackColor = Color.Yellow;
        }

        private void txt_cpf_Leave(object sender, EventArgs e)
        {
            txt_cpf.BackColor = Color.White;
        }

        private void txt_cpf_Enter(object sender, EventArgs e)
        {
            txt_cpf.BackColor = Color.Yellow;
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            txtValor.BackColor = Color.Yellow;
        }

        private void txtReferente_Leave(object sender, EventArgs e)
        {
            txtReferente.BackColor = Color.White;
        }

        private void txtReferente_Enter(object sender, EventArgs e)
        {
            txtReferente.BackColor = Color.Yellow;
        }

        private void txt_emissor_Leave(object sender, EventArgs e)
        {
            txt_emissor.BackColor = Color.White;
        }

        private void txt_emissor_Enter(object sender, EventArgs e)
        {
            txt_emissor.BackColor = Color.Yellow;
        }

        private void txtValor_Click(object sender, EventArgs e)
        {
            if (txtValor.Text != string.Empty)
            {
                txtValor.Text  = ReplaceValores(txtValor);
            }           
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {      
            if (txtValor.Text != string.Empty)
            {
                txtValor.Text = ReplaceValores(txtValor);
            }
        }

        private void FrmRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }


    //******************NÃO ORIGINAL

    public class Converter
    {
        // O método toExtenso recebe um valor do tipo decimal
        public static string toExtenso(decimal valor)
        {
            if (valor <= 0 | valor >= 1000000000000000)
                return "Valor não suportado pelo sistema.";
            else
            {
                string strValor = valor.ToString("000000000000000.00");
                string valor_por_extenso = string.Empty;

                for (int i = 0; i <= 15; i += 3)
                {
                    valor_por_extenso += escreva_parte(Convert.ToDecimal(strValor.Substring(i, 3)));
                    if (i == 0 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(0, 3)) == 1)
                            valor_por_extenso += " trilhão" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " e " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(0, 3)) > 1)
                            valor_por_extenso += " trilhões" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " e " : string.Empty);
                    }
                    else if (i == 3 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
                            valor_por_extenso += " bilhão" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " e " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
                            valor_por_extenso += " bilhões" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " e " : string.Empty);
                    }
                    else if (i == 6 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
                            valor_por_extenso += " milhão" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " e " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
                            valor_por_extenso += " milhões" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " e " : string.Empty);
                    }
                    else if (i == 9 & valor_por_extenso != string.Empty)
                        if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
                            valor_por_extenso += " mil" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0) ? " e " : string.Empty);

                    if (i == 12)
                    {
                        if (valor_por_extenso.Length > 8)
                            if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "bilhão" | valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "milhão")
                                valor_por_extenso += " de";
                            else
                                if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "bilhões" | valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "milhões" | valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "TRILHÕES")
                                    valor_por_extenso += " de";
                                else
                                    if (valor_por_extenso.Substring(valor_por_extenso.Length - 8, 8) == "trilhões")
                                        valor_por_extenso += " de";

                        if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
                            valor_por_extenso += " real";
                        else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
                            valor_por_extenso += " reais";

                        if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
                            valor_por_extenso += " e ";
                    }

                    if (i == 15)
                        if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
                            valor_por_extenso += " centavo";
                        else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
                            valor_por_extenso += " centavos";
                }
                return valor_por_extenso;
            }
        }

        static string escreva_parte(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));

                if (a == 1) montagem += (b + c == 0) ? "cem" : "cento";
                else if (a == 2) montagem += "duzentos";
                else if (a == 3) montagem += "trezentos";
                else if (a == 4) montagem += "quatrocentos";
                else if (a == 5) montagem += "quinhentos";
                else if (a == 6) montagem += "seiscentos";
                else if (a == 7) montagem += "setecetos";
                else if (a == 8) montagem += "oitocentos";
                else if (a == 9) montagem += "novecentos";

                if (b == 1)
                {
                    if (c == 0) montagem += ((a > 0) ? " e " : string.Empty) + "dez";
                    else if (c == 1) montagem += ((a > 0) ? " e " : string.Empty) + "onze";
                    else if (c == 2) montagem += ((a > 0) ? " e " : string.Empty) + "doze";
                    else if (c == 3) montagem += ((a > 0) ? " e " : string.Empty) + "treze";
                    else if (c == 4) montagem += ((a > 0) ? " e " : string.Empty) + "quatorze";
                    else if (c == 5) montagem += ((a > 0) ? " e " : string.Empty) + "quinze";
                    else if (c == 6) montagem += ((a > 0) ? " e " : string.Empty) + "dezesseis";
                    else if (c == 7) montagem += ((a > 0) ? " e " : string.Empty) + "dezessete";
                    else if (c == 8) montagem += ((a > 0) ? " e " : string.Empty) + "dezoito";
                    else if (c == 9) montagem += ((a > 0) ? " e " : string.Empty) + "dezenove";
                }
                else if (b == 2) montagem += ((a > 0) ? " e " : string.Empty) + "vinte";
                else if (b == 3) montagem += ((a > 0) ? " e " : string.Empty) + "trinta";
                else if (b == 4) montagem += ((a > 0) ? " e " : string.Empty) + "quarenta";
                else if (b == 5) montagem += ((a > 0) ? " e " : string.Empty) + "cinquenta";
                else if (b == 6) montagem += ((a > 0) ? " e " : string.Empty) + "sessenta";
                else if (b == 7) montagem += ((a > 0) ? " e " : string.Empty) + "setenta";
                else if (b == 8) montagem += ((a > 0) ? " e " : string.Empty) + "oitenta";
                else if (b == 9) montagem += ((a > 0) ? " e " : string.Empty) + "noventa";

                if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " e ";

                if (strValor.Substring(1, 1) != "1")
                    if (c == 1) montagem += "um";
                    else if (c == 2) montagem += "dois";
                    else if (c == 3) montagem += "três";
                    else if (c == 4) montagem += "quatro";
                    else if (c == 5) montagem += "cinco";
                    else if (c == 6) montagem += "seis";
                    else if (c == 7) montagem += "sete";
                    else if (c == 8) montagem += "oito";
                    else if (c == 9) montagem += "nove";

                return montagem;
            }
        }
    }
    //**************************************
}
