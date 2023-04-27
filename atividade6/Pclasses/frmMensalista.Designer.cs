namespace Pclasses
{
    partial class frmMensalista
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
            this.btnInstanciar1 = new System.Windows.Forms.Button();
            this.btnInstanciar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.rdnHome1 = new System.Windows.Forms.RadioButton();
            this.rdbHome2 = new System.Windows.Forms.RadioButton();
            this.gpbHome = new System.Windows.Forms.GroupBox();
            this.gpbHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstanciar1
            // 
            this.btnInstanciar1.Location = new System.Drawing.Point(147, 322);
            this.btnInstanciar1.Name = "btnInstanciar1";
            this.btnInstanciar1.Size = new System.Drawing.Size(141, 62);
            this.btnInstanciar1.TabIndex = 0;
            this.btnInstanciar1.Text = "Instanciar mensalista";
            this.btnInstanciar1.UseVisualStyleBackColor = true;
            this.btnInstanciar1.Click += new System.EventHandler(this.BtnInstanciar1_Click);
            // 
            // btnInstanciar2
            // 
            this.btnInstanciar2.Location = new System.Drawing.Point(445, 322);
            this.btnInstanciar2.Name = "btnInstanciar2";
            this.btnInstanciar2.Size = new System.Drawing.Size(133, 68);
            this.btnInstanciar2.TabIndex = 1;
            this.btnInstanciar2.Text = "Instanciar Mensalista com parametros";
            this.btnInstanciar2.UseVisualStyleBackColor = true;
            this.btnInstanciar2.Click += new System.EventHandler(this.BtnInstanciar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salario mensal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de entrada na empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(217, 56);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(217, 169);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(217, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(217, 219);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 9;
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
            // gpbHome
            // 
            this.gpbHome.Controls.Add(this.rdnHome1);
            this.gpbHome.Controls.Add(this.rdbHome2);
            this.gpbHome.Location = new System.Drawing.Point(561, 56);
            this.gpbHome.Name = "gpbHome";
            this.gpbHome.Size = new System.Drawing.Size(200, 133);
            this.gpbHome.TabIndex = 12;
            this.gpbHome.TabStop = false;
            this.gpbHome.Text = "Trabalha Home office?";
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbHome);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstanciar2);
            this.Controls.Add(this.btnInstanciar1);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gpbHome.ResumeLayout(false);
            this.gpbHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstanciar1;
        private System.Windows.Forms.Button btnInstanciar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.RadioButton rdnHome1;
        private System.Windows.Forms.RadioButton rdbHome2;
        private System.Windows.Forms.GroupBox gpbHome;
    }
}