
namespace Condominio
{
    partial class LancarDebito
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAno = new Condominio.Util.TxtQuantidade();
            this.btnLancarDebitos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.btnApagarDebito = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMesAno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtCriacao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Mês:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAno);
            this.groupBox1.Controls.Add(this.btnLancarDebitos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboMes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lançamento de Débitos";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(169, 105);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(125, 34);
            this.txtAno.TabIndex = 3;
            this.txtAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLancarDebitos
            // 
            this.btnLancarDebitos.Location = new System.Drawing.Point(103, 169);
            this.btnLancarDebitos.Name = "btnLancarDebitos";
            this.btnLancarDebitos.Size = new System.Drawing.Size(160, 52);
            this.btnLancarDebitos.TabIndex = 4;
            this.btnLancarDebitos.Tag = "Essa operação irá lançar débitos em todos os condôminos cadastrados.";
            this.btnLancarDebitos.Text = "Lançar Débitos";
            this.btnLancarDebitos.UseVisualStyleBackColor = true;
            this.btnLancarDebitos.Click += new System.EventHandler(this.btnLancarDebitos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira o Ano:";
            // 
            // comboMes
            // 
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(169, 53);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(147, 36);
            this.comboMes.TabIndex = 1;
            // 
            // btnApagarDebito
            // 
            this.btnApagarDebito.Location = new System.Drawing.Point(151, 169);
            this.btnApagarDebito.Name = "btnApagarDebito";
            this.btnApagarDebito.Size = new System.Drawing.Size(160, 52);
            this.btnApagarDebito.TabIndex = 5;
            this.btnApagarDebito.Text = "Cancelar Débito";
            this.btnApagarDebito.UseVisualStyleBackColor = true;
            this.btnApagarDebito.Click += new System.EventHandler(this.btnApagarDebito_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMesAno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtCriacao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnApagarDebito);
            this.groupBox2.Location = new System.Drawing.Point(486, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 254);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Último Débito Lançado";
            // 
            // txtMesAno
            // 
            this.txtMesAno.Enabled = false;
            this.txtMesAno.Location = new System.Drawing.Point(114, 100);
            this.txtMesAno.Name = "txtMesAno";
            this.txtMesAno.Size = new System.Drawing.Size(156, 34);
            this.txtMesAno.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mês/Ano: ";
            // 
            // dtCriacao
            // 
            this.dtCriacao.Enabled = false;
            this.dtCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCriacao.Location = new System.Drawing.Point(168, 46);
            this.dtCriacao.Name = "dtCriacao";
            this.dtCriacao.Size = new System.Drawing.Size(159, 34);
            this.dtCriacao.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Criação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(679, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ao cancelar débitos, não serão cancelados débitos já pagos de condôminos. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(584, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ao registrar o pagamento de um condômino é gerado um recibo.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(770, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ao gerar um recibo o débito referente é automaticamente retirado do banco de dado" +
    "s.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(24, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(909, 133);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LancarDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LancarDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Débitos";
            this.Load += new System.EventHandler(this.LancarDebito_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.Button btnLancarDebitos;
        private System.Windows.Forms.Button btnApagarDebito;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMesAno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtCriacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private Util.TxtQuantidade txtAno;
        private System.Windows.Forms.Button button1;
    }
}