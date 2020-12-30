using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teorema_de_Pitágoras
{
    public partial class frmTeoremaPitagoras : Form
    {
        public frmTeoremaPitagoras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double catmenor = 0;
            double catmaior = 0;
            double hipotenusa = 0;
            double resultado = 0;
            DialogResult resposta;
            if (radbtnCatMenor.Checked)
            {
               
                if (txtCatMaior.Text == "")
                {
                    resposta = MessageBox.Show("Não pode ter campo nulo", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    catmaior = double.Parse(txtCatMaior.Text);
                if (txtHipotenusa.Text == "")
                {
                    resposta = MessageBox.Show("Não pode ter campo nulo", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    hipotenusa = double.Parse(txtHipotenusa.Text);
                if (catmaior > hipotenusa)
                    resposta = MessageBox.Show("Cateto maior não pode ser maior do que a hipotenusa!", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    resultado = Math.Sqrt((hipotenusa * hipotenusa) - (catmaior * catmaior));
                    if (radbtnCmInicial.Checked)
                    {
                        if (radbtnCmFinal.Checked)
                        {
                            lblResp.Text = resultado.ToString("N2");
                        }
                        else if (radbtnMetrosFinal.Checked)
                        {
                            resultado = resultado / 100;
                            lblResp.Text = resultado.ToString("N2");
                        }
                    }
                    else if (radbtnMetrosInicial.Checked)
                    {
                        if (radbtnCmFinal.Checked)
                        {
                            resultado = resultado * 100;
                            lblResp.Text = resultado.ToString("N2");
                        }
                        else if (radbtnMetrosFinal.Checked)
                        {
                            lblResp.Text = resultado.ToString("N2");
                        }
                    }
                }
            }
            if (radbtnCatMaior.Checked)
            {
                if (txtCatMenor.Text == "")
                {
                    resposta = MessageBox.Show("Não pode ter campo nulo", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    catmenor = double.Parse(txtCatMenor.Text);
                if (txtHipotenusa.Text == "")
                {
                    resposta = MessageBox.Show("Não pode ter campo nulo", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    hipotenusa = double.Parse(txtHipotenusa.Text);
                if (catmenor > hipotenusa)
                    resposta = MessageBox.Show("Cateto menor não pode ser maior do que a hipotenusa!", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    resultado = Math.Sqrt((hipotenusa * hipotenusa) - (catmenor * catmenor));
                    if (radbtnCmInicial.Checked)
                    {
                        if (radbtnCmFinal.Checked)
                        {
                            lblResp.Text = resultado.ToString("N2");
                        }
                        else if (radbtnMetrosFinal.Checked)
                        {
                            resultado = resultado / 100;
                            lblResp.Text = resultado.ToString("N2");
                        }
                    }
                    else if (radbtnMetrosInicial.Checked)
                    {
                        if (radbtnCmFinal.Checked)
                        {
                            resultado = resultado * 100;
                            lblResp.Text = resultado.ToString("N2");
                        }
                        else if (radbtnMetrosFinal.Checked)
                        {
                            lblResp.Text = resultado.ToString("N2");
                        }
                    }
                }
            }
            if (radbtnHipotenusa.Checked)
            {
                if (txtCatMaior.Text == "")
                {
                    resposta = MessageBox.Show("Não pode ter campo nulo", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    catmaior = double.Parse(txtCatMaior.Text);
                if (txtCatMenor.Text == "")
                {
                    resposta = MessageBox.Show("Não pode ter campo nulo", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    catmenor = double.Parse(txtCatMenor.Text);
                if (catmenor > catmaior)
                    resposta = MessageBox.Show("Cateto maior não pode ser maior do que a hipotenusa!", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    resultado = Math.Sqrt((catmaior * catmaior) + (catmenor * catmenor));
                    if (radbtnCmInicial.Checked)
                    {
                        if (radbtnCmFinal.Checked)
                        {
                            lblResp.Text = resultado.ToString("N2");
                        }
                        else if (radbtnMetrosFinal.Checked)
                        {
                            resultado = resultado / 100;
                            lblResp.Text = resultado.ToString("N2");
                        }
                    }
                    else if (radbtnMetrosInicial.Checked)
                    {
                        if (radbtnCmFinal.Checked)
                        {
                            resultado = resultado * 100;
                            lblResp.Text = resultado.ToString("N2");
                        }
                        else if (radbtnMetrosFinal.Checked)
                        {
                            lblResp.Text = resultado.ToString("N2");
                        }
                    }
                }
            }
        }

        private void limpaTextBox (Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                    ((TextBox)(ctrl)).Text = String.Empty; 
            }
        }
        private void radbtnCatMenor_Click(object sender, EventArgs e)
        {
            limpaTextBox(this.Controls);
            txtCatMenor.Enabled = false;
            txtCatMaior.Enabled = true;
            txtHipotenusa.Enabled = true;
        }

        private void radbtnCatMaior_Click(object sender, EventArgs e)
        {
            limpaTextBox(this.Controls);
            lblResp.Text = String.Empty;
            txtCatMenor.Enabled = true;
            txtCatMaior.Enabled = false;
            txtHipotenusa.Enabled = true;
        }

        private void radbtnHipotenusa_Click(object sender, EventArgs e)
        {
            limpaTextBox(this.Controls);
            txtCatMenor.Enabled = true;
            txtCatMaior.Enabled = true;
            txtHipotenusa.Enabled = false;
        }

        private void txtCatMenor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&&(e.KeyChar!='.')&&(e.KeyChar!='-'))
            {
                e.Handled = true;

            }
        }

        private void txtCatMaior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;

            }
        }

        private void txtHipotenusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair;
            sair = MessageBox.Show("Deseja sair?", "Teorema de Pitágoras- Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
                Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpaTextBox(this.Controls);
            lblResp.Text = String.Empty;
        }

        private void radbtnCmInicial_CheckedChanged(object sender, EventArgs e)
        {
            if(radbtnCmInicial.Checked)
            {
                lblCatMaior1.Text = "cm";
                lblCatMenor1.Text = "cm";
                lblHipotenusa1.Text = "cm";

                if (txtCatMaior.Text != "")
                {
                    double CatMaior = double.Parse(txtCatMaior.Text) * 100;
                    txtCatMaior.Text = CatMaior.ToString("N2");
                }

                if (txtCatMenor.Text != "")
                {
                    double CatMenor = double.Parse(txtCatMenor.Text) * 100;
                    txtCatMenor.Text = CatMenor.ToString("N2");
                }

                if (txtHipotenusa.Text != "")
                {
                    double Hip = double.Parse(txtHipotenusa.Text) * 100;
                    txtHipotenusa.Text = Hip.ToString("N2");
                }
            }
        }

        private void radbtnMetrosInicial_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnMetrosInicial.Checked)
            {
                lblCatMaior1.Text = "m";
                lblCatMenor1.Text = "m";
                lblHipotenusa1.Text = "m";

                if (txtCatMaior.Text != "")
                {
                    double CatMaior = double.Parse(txtCatMaior.Text) / 100;
                    txtCatMaior.Text = CatMaior.ToString("N2");
                }

                if (txtCatMenor.Text != "")
                {
                    double CatMenor = double.Parse(txtCatMenor.Text) / 100;
                    txtCatMenor.Text = CatMenor.ToString("N2");
                }

                if (txtHipotenusa.Text != "")
                {
                    double Hip = double.Parse(txtHipotenusa.Text) / 100;
                    txtHipotenusa.Text = Hip.ToString("N2");
                }
            }
        }

        private void radbtnCmFinal_CheckedChanged(object sender, EventArgs e)
        {
            if(radbtnCmFinal.Checked)
            {
                lblUnidResp.Text = "cm";

                if (lblResp.Text != "")
                {
                    double Resp = double.Parse(lblResp.Text) * 100;
                    lblResp.Text = Resp.ToString("N2");
                }
            }
        }

        private void radbtnMetrosFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnMetrosFinal.Checked)
            {
                lblUnidResp.Text = "m";

                if (lblResp.Text != "")
                {
                    double Resp = double.Parse(lblResp.Text) / 100;
                    lblResp.Text = Resp.ToString("N2");
                }
            }
        }
    }
}
