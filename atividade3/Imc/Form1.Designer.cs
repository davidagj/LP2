namespace Imc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblICM = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtICM = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(156, 86);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(156, 133);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // lblICM
            // 
            this.lblICM.AutoSize = true;
            this.lblICM.Location = new System.Drawing.Point(156, 181);
            this.lblICM.Name = "lblICM";
            this.lblICM.Size = new System.Drawing.Size(26, 13);
            this.lblICM.TabIndex = 2;
            this.lblICM.Text = "ICM";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(140, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(304, 277);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(476, 277);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(304, 86);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.TextChanged += new System.EventHandler(this.TxtPeso_TextChanged);
            this.txtPeso.Validated += new System.EventHandler(this.TxtPeso_Validated);
            // 
            // txtICM
            // 
            this.txtICM.Enabled = false;
            this.txtICM.Location = new System.Drawing.Point(304, 181);
            this.txtICM.Name = "txtICM";
            this.txtICM.Size = new System.Drawing.Size(100, 20);
            this.txtICM.TabIndex = 7;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(304, 133);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 8;
            this.txtAltura.Validated += new System.EventHandler(this.TxtAltura_Validated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtICM);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblICM);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "ICM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblICM;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtICM;
        private System.Windows.Forms.TextBox txtAltura;
    }
}

