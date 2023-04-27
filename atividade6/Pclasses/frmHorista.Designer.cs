namespace Pclasses
{
    partial class frmHorista
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
            this.gpbHome = new System.Windows.Forms.GroupBox();
            this.rdnHome1 = new System.Windows.Forms.RadioButton();
            this.rdbHome2 = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnInstanciar1 = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtNhoras = new System.Windows.Forms.TextBox();
            this.lblFalta = new System.Windows.Forms.Label();
            this.txtFalta = new System.Windows.Forms.TextBox();
            this.gpbHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbHome
            // 
            this.gpbHome.Controls.Add(this.rdnHome1);
            this.gpbHome.Controls.Add(this.rdbHome2);
            this.gpbHome.Location = new System.Drawing.Point(556, 58);
            this.gpbHome.Name = "gpbHome";
            this.gpbHome.Size = new System.Drawing.Size(200, 133);
            this.gpbHome.TabIndex = 23;
            this.gpbHome.TabStop = false;
            this.gpbHome.Text = "Trabalha Home office?";
            // 
            // rdnHome1
            // 
            this.rdnHome1.AutoSize = true;
            this.rdnHome1.Location = new System.Drawing.Point(39, 63);
            this.rdnHome1.Name = "rdnHome1";
            this.rdnHome1.Size = new System.Drawing.Size(43, 17);
            this.rdnHome1.TabIndex = 10;
            this.rdnHome1.Text = "SIm";
            this.rdnHome1.UseVisualStyleBackColor = true;
            // 
            // rdbHome2
            // 
            this.rdbHome2.AutoSize = true;
            this.rdbHome2.Checked = true;
            this.rdbHome2.Location = new System.Drawing.Point(39, 86);
            this.rdbHome2.Name = "rdbHome2";
            this.rdbHome2.Size = new System.Drawing.Size(45, 17);
            this.rdbHome2.TabIndex = 11;
            this.rdbHome2.TabStop = true;
            this.rdbHome2.Text = "Não";
            this.rdbHome2.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(212, 221);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 22;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(212, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 21;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(212, 141);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 20;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(212, 58);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 19;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(44, 228);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(142, 13);
            this.lblData.TabIndex = 18;
            this.lblData.Text = "Data de entrada na empresa";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(44, 144);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(63, 13);
            this.lblSalario.TabIndex = 17;
            this.lblSalario.Text = "Salario hora";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(44, 105);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(44, 61);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 15;
            this.lblMatricula.Text = "Matricula";
            // 
            // btnInstanciar1
            // 
            this.btnInstanciar1.Location = new System.Drawing.Point(322, 308);
            this.btnInstanciar1.Name = "btnInstanciar1";
            this.btnInstanciar1.Size = new System.Drawing.Size(141, 62);
            this.btnInstanciar1.TabIndex = 13;
            this.btnInstanciar1.Text = "Instanciar horista";
            this.btnInstanciar1.UseVisualStyleBackColor = true;
            this.btnInstanciar1.Click += new System.EventHandler(this.BtnInstanciar1_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(44, 178);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(88, 13);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "Numero de horas";
            // 
            // txtNhoras
            // 
            this.txtNhoras.Location = new System.Drawing.Point(212, 178);
            this.txtNhoras.Name = "txtNhoras";
            this.txtNhoras.Size = new System.Drawing.Size(100, 20);
            this.txtNhoras.TabIndex = 25;
            // 
            // lblFalta
            // 
            this.lblFalta.AutoSize = true;
            this.lblFalta.Location = new System.Drawing.Point(44, 264);
            this.lblFalta.Name = "lblFalta";
            this.lblFalta.Size = new System.Drawing.Size(71, 13);
            this.lblFalta.TabIndex = 26;
            this.lblFalta.Text = "Dias de faltas";
            // 
            // txtFalta
            // 
            this.txtFalta.Location = new System.Drawing.Point(212, 257);
            this.txtFalta.Name = "txtFalta";
            this.txtFalta.Size = new System.Drawing.Size(100, 20);
            this.txtFalta.TabIndex = 27;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFalta);
            this.Controls.Add(this.lblFalta);
            this.Controls.Add(this.txtNhoras);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.gpbHome);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnInstanciar1);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.gpbHome.ResumeLayout(false);
            this.gpbHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbHome;
        private System.Windows.Forms.RadioButton rdnHome1;
        private System.Windows.Forms.RadioButton rdbHome2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnInstanciar1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtNhoras;
        private System.Windows.Forms.Label lblFalta;
        private System.Windows.Forms.TextBox txtFalta;
    }
}