
namespace Condominio
{
    partial class CadastroCondomino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCondomino));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDebito = new Condominio.Util.TxtValor();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(27, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1318, 642);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condômino";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(1158, 562);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 55);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Voltar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(493, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar Condômino";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTelefone);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtVeiculo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtRepresentante);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(590, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(722, 325);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Representante";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTelefone.Location = new System.Drawing.Point(113, 120);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(288, 34);
            this.txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(445, 34);
            this.txtEmail.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail:";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVeiculo.Location = new System.Drawing.Point(194, 193);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(347, 34);
            this.txtVeiculo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Veiculo(s) Placa(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone:";
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtRepresentante.Location = new System.Drawing.Point(250, 51);
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(445, 34);
            this.txtRepresentante.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Representante/Inquilino:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDebito);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtProprietario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCasa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 325);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Casa";
            // 
            // txtDebito
            // 
            this.txtDebito.Location = new System.Drawing.Point(176, 235);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.Size = new System.Drawing.Size(125, 34);
            this.txtDebito.TabIndex = 4;
            this.txtDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Débito Anterior:";
            // 
            // txtProprietario
            // 
            this.txtProprietario.Location = new System.Drawing.Point(176, 168);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(383, 34);
            this.txtProprietario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proprietário(a):*";
            // 
            // txtCasa
            // 
            this.txtCasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCasa.Location = new System.Drawing.Point(189, 51);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.PlaceholderText = "Número e complemento da casa";
            this.txtCasa.Size = new System.Drawing.Size(308, 34);
            this.txtCasa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da Casa:*";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(19, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(540, 70);
            this.label8.TabIndex = 9;
            this.label8.Text = "O Número da Casa e seu complemento precisa ser único, ou seja, diferente de outro" +
    "s moradores.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CadastroCondomino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroCondomino";
            this.Text = "Cadastro de Condômino";
            this.Load += new System.EventHandler(this.CadastroCondomino_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProprietario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private Util.TxtValor txtDebito;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label8;
    }
}