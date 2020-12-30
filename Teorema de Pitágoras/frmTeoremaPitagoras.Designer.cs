namespace Teorema_de_Pitágoras
{
    partial class frmTeoremaPitagoras
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.radbtnCatMenor = new System.Windows.Forms.RadioButton();
            this.radbtnCatMaior = new System.Windows.Forms.RadioButton();
            this.radbtnHipotenusa = new System.Windows.Forms.RadioButton();
            this.grpboxEscolha = new System.Windows.Forms.GroupBox();
            this.grpboxUniMedidaInicial = new System.Windows.Forms.GroupBox();
            this.radbtnCmInicial = new System.Windows.Forms.RadioButton();
            this.radbtnMetrosInicial = new System.Windows.Forms.RadioButton();
            this.grpboxUniMedidaFinal = new System.Windows.Forms.GroupBox();
            this.txtCatMenor = new System.Windows.Forms.TextBox();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.txtCatMaior = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCatMenor1 = new System.Windows.Forms.Label();
            this.lblCatMaior1 = new System.Windows.Forms.Label();
            this.lblHipotenusa1 = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.radbtnCmFinal = new System.Windows.Forms.RadioButton();
            this.radbtnMetrosFinal = new System.Windows.Forms.RadioButton();
            this.lblUnidResp = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxEscolha.SuspendLayout();
            this.grpboxUniMedidaInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // radbtnCatMenor
            // 
            this.radbtnCatMenor.AutoSize = true;
            this.radbtnCatMenor.Checked = true;
            this.radbtnCatMenor.Location = new System.Drawing.Point(6, 24);
            this.radbtnCatMenor.Name = "radbtnCatMenor";
            this.radbtnCatMenor.Size = new System.Drawing.Size(88, 17);
            this.radbtnCatMenor.TabIndex = 0;
            this.radbtnCatMenor.TabStop = true;
            this.radbtnCatMenor.Text = "Cateto menor";
            this.radbtnCatMenor.UseVisualStyleBackColor = true;
            this.radbtnCatMenor.Click += new System.EventHandler(this.radbtnCatMenor_Click);
            // 
            // radbtnCatMaior
            // 
            this.radbtnCatMaior.AutoSize = true;
            this.radbtnCatMaior.Location = new System.Drawing.Point(6, 47);
            this.radbtnCatMaior.Name = "radbtnCatMaior";
            this.radbtnCatMaior.Size = new System.Drawing.Size(84, 17);
            this.radbtnCatMaior.TabIndex = 1;
            this.radbtnCatMaior.Text = "Cateto maior";
            this.radbtnCatMaior.UseVisualStyleBackColor = true;
            this.radbtnCatMaior.Click += new System.EventHandler(this.radbtnCatMaior_Click);
            // 
            // radbtnHipotenusa
            // 
            this.radbtnHipotenusa.AutoSize = true;
            this.radbtnHipotenusa.Location = new System.Drawing.Point(6, 70);
            this.radbtnHipotenusa.Name = "radbtnHipotenusa";
            this.radbtnHipotenusa.Size = new System.Drawing.Size(79, 17);
            this.radbtnHipotenusa.TabIndex = 2;
            this.radbtnHipotenusa.Text = "Hipotenusa";
            this.radbtnHipotenusa.UseVisualStyleBackColor = true;
            this.radbtnHipotenusa.Click += new System.EventHandler(this.radbtnHipotenusa_Click);
            // 
            // grpboxEscolha
            // 
            this.grpboxEscolha.Controls.Add(this.grpboxUniMedidaInicial);
            this.grpboxEscolha.Controls.Add(this.grpboxUniMedidaFinal);
            this.grpboxEscolha.Controls.Add(this.radbtnCatMaior);
            this.grpboxEscolha.Controls.Add(this.radbtnHipotenusa);
            this.grpboxEscolha.Controls.Add(this.radbtnCatMenor);
            this.grpboxEscolha.Location = new System.Drawing.Point(30, 42);
            this.grpboxEscolha.Name = "grpboxEscolha";
            this.grpboxEscolha.Size = new System.Drawing.Size(200, 225);
            this.grpboxEscolha.TabIndex = 3;
            this.grpboxEscolha.TabStop = false;
            this.grpboxEscolha.Text = "Selecione o que deseja descobrir:";
            // 
            // grpboxUniMedidaInicial
            // 
            this.grpboxUniMedidaInicial.Controls.Add(this.radbtnCmInicial);
            this.grpboxUniMedidaInicial.Controls.Add(this.radbtnMetrosInicial);
            this.grpboxUniMedidaInicial.Location = new System.Drawing.Point(0, 107);
            this.grpboxUniMedidaInicial.Name = "grpboxUniMedidaInicial";
            this.grpboxUniMedidaInicial.Size = new System.Drawing.Size(200, 85);
            this.grpboxUniMedidaInicial.TabIndex = 16;
            this.grpboxUniMedidaInicial.TabStop = false;
            this.grpboxUniMedidaInicial.Text = "Selecione a unidade de medida inicial:";
            // 
            // radbtnCmInicial
            // 
            this.radbtnCmInicial.AutoSize = true;
            this.radbtnCmInicial.Checked = true;
            this.radbtnCmInicial.Location = new System.Drawing.Point(6, 38);
            this.radbtnCmInicial.Name = "radbtnCmInicial";
            this.radbtnCmInicial.Size = new System.Drawing.Size(39, 17);
            this.radbtnCmInicial.TabIndex = 8;
            this.radbtnCmInicial.TabStop = true;
            this.radbtnCmInicial.Text = "cm";
            this.radbtnCmInicial.UseVisualStyleBackColor = true;
            this.radbtnCmInicial.CheckedChanged += new System.EventHandler(this.radbtnCmInicial_CheckedChanged);
            // 
            // radbtnMetrosInicial
            // 
            this.radbtnMetrosInicial.AutoSize = true;
            this.radbtnMetrosInicial.Location = new System.Drawing.Point(61, 38);
            this.radbtnMetrosInicial.Name = "radbtnMetrosInicial";
            this.radbtnMetrosInicial.Size = new System.Drawing.Size(33, 17);
            this.radbtnMetrosInicial.TabIndex = 9;
            this.radbtnMetrosInicial.Text = "m";
            this.radbtnMetrosInicial.UseVisualStyleBackColor = true;
            this.radbtnMetrosInicial.CheckedChanged += new System.EventHandler(this.radbtnMetrosInicial_CheckedChanged);
            // 
            // grpboxUniMedidaFinal
            // 
            this.grpboxUniMedidaFinal.Location = new System.Drawing.Point(0, 191);
            this.grpboxUniMedidaFinal.Name = "grpboxUniMedidaFinal";
            this.grpboxUniMedidaFinal.Size = new System.Drawing.Size(200, 107);
            this.grpboxUniMedidaFinal.TabIndex = 3;
            this.grpboxUniMedidaFinal.TabStop = false;
            this.grpboxUniMedidaFinal.Text = "Selecione a unidade de medida final:";
            // 
            // txtCatMenor
            // 
            this.txtCatMenor.Location = new System.Drawing.Point(250, 81);
            this.txtCatMenor.Name = "txtCatMenor";
            this.txtCatMenor.Size = new System.Drawing.Size(100, 20);
            this.txtCatMenor.TabIndex = 4;
            this.txtCatMenor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatMenor_KeyPress);
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.Location = new System.Drawing.Point(250, 127);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(100, 20);
            this.txtHipotenusa.TabIndex = 5;
            this.txtHipotenusa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHipotenusa_KeyPress);
            // 
            // txtCatMaior
            // 
            this.txtCatMaior.Location = new System.Drawing.Point(250, 104);
            this.txtCatMaior.Name = "txtCatMaior";
            this.txtCatMaior.Size = new System.Drawing.Size(100, 20);
            this.txtCatMaior.TabIndex = 6;
            this.txtCatMaior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCatMaior_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(260, 160);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCatMenor1
            // 
            this.lblCatMenor1.AutoSize = true;
            this.lblCatMenor1.Location = new System.Drawing.Point(371, 88);
            this.lblCatMenor1.Name = "lblCatMenor1";
            this.lblCatMenor1.Size = new System.Drawing.Size(21, 13);
            this.lblCatMenor1.TabIndex = 10;
            this.lblCatMenor1.Text = "cm";
            // 
            // lblCatMaior1
            // 
            this.lblCatMaior1.AutoSize = true;
            this.lblCatMaior1.Location = new System.Drawing.Point(371, 111);
            this.lblCatMaior1.Name = "lblCatMaior1";
            this.lblCatMaior1.Size = new System.Drawing.Size(21, 13);
            this.lblCatMaior1.TabIndex = 11;
            this.lblCatMaior1.Text = "cm";
            // 
            // lblHipotenusa1
            // 
            this.lblHipotenusa1.AutoSize = true;
            this.lblHipotenusa1.Location = new System.Drawing.Point(371, 134);
            this.lblHipotenusa1.Name = "lblHipotenusa1";
            this.lblHipotenusa1.Size = new System.Drawing.Size(21, 13);
            this.lblHipotenusa1.TabIndex = 12;
            this.lblHipotenusa1.Text = "cm";
            // 
            // lblResp
            // 
            this.lblResp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblResp.Location = new System.Drawing.Point(428, 109);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(100, 20);
            this.lblResp.TabIndex = 14;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radbtnCmFinal
            // 
            this.radbtnCmFinal.AutoSize = true;
            this.radbtnCmFinal.Checked = true;
            this.radbtnCmFinal.Location = new System.Drawing.Point(36, 261);
            this.radbtnCmFinal.Name = "radbtnCmFinal";
            this.radbtnCmFinal.Size = new System.Drawing.Size(39, 17);
            this.radbtnCmFinal.TabIndex = 10;
            this.radbtnCmFinal.TabStop = true;
            this.radbtnCmFinal.Text = "cm";
            this.radbtnCmFinal.UseVisualStyleBackColor = true;
            this.radbtnCmFinal.CheckedChanged += new System.EventHandler(this.radbtnCmFinal_CheckedChanged);
            // 
            // radbtnMetrosFinal
            // 
            this.radbtnMetrosFinal.AutoSize = true;
            this.radbtnMetrosFinal.Location = new System.Drawing.Point(105, 261);
            this.radbtnMetrosFinal.Name = "radbtnMetrosFinal";
            this.radbtnMetrosFinal.Size = new System.Drawing.Size(33, 17);
            this.radbtnMetrosFinal.TabIndex = 10;
            this.radbtnMetrosFinal.Text = "m";
            this.radbtnMetrosFinal.UseVisualStyleBackColor = true;
            this.radbtnMetrosFinal.CheckedChanged += new System.EventHandler(this.radbtnMetrosFinal_CheckedChanged);
            // 
            // lblUnidResp
            // 
            this.lblUnidResp.AutoSize = true;
            this.lblUnidResp.Location = new System.Drawing.Point(560, 116);
            this.lblUnidResp.Name = "lblUnidResp";
            this.lblUnidResp.Size = new System.Drawing.Size(21, 13);
            this.lblUnidResp.TabIndex = 18;
            this.lblUnidResp.Text = "cm";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(260, 255);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(389, 255);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Resposta:";
            // 
            // frmTeoremaPitagoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblUnidResp);
            this.Controls.Add(this.radbtnMetrosFinal);
            this.Controls.Add(this.radbtnCmFinal);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.lblHipotenusa1);
            this.Controls.Add(this.lblCatMaior1);
            this.Controls.Add(this.lblCatMenor1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCatMaior);
            this.Controls.Add(this.txtHipotenusa);
            this.Controls.Add(this.txtCatMenor);
            this.Controls.Add(this.grpboxEscolha);
            this.Name = "frmTeoremaPitagoras";
            this.Text = "Teorema de Pitágoras";
            this.grpboxEscolha.ResumeLayout(false);
            this.grpboxEscolha.PerformLayout();
            this.grpboxUniMedidaInicial.ResumeLayout(false);
            this.grpboxUniMedidaInicial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radbtnCatMenor;
        private System.Windows.Forms.RadioButton radbtnCatMaior;
        private System.Windows.Forms.RadioButton radbtnHipotenusa;
        private System.Windows.Forms.GroupBox grpboxEscolha;
        private System.Windows.Forms.TextBox txtCatMenor;
        private System.Windows.Forms.TextBox txtHipotenusa;
        private System.Windows.Forms.TextBox txtCatMaior;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton radbtnCmInicial;
        private System.Windows.Forms.RadioButton radbtnMetrosInicial;
        private System.Windows.Forms.Label lblCatMenor1;
        private System.Windows.Forms.Label lblCatMaior1;
        private System.Windows.Forms.Label lblHipotenusa1;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.GroupBox grpboxUniMedidaInicial;
        private System.Windows.Forms.GroupBox grpboxUniMedidaFinal;
        private System.Windows.Forms.RadioButton radbtnCmFinal;
        private System.Windows.Forms.RadioButton radbtnMetrosFinal;
        private System.Windows.Forms.Label lblUnidResp;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
    }
}

