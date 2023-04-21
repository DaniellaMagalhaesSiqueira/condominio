
namespace Condominio
{
    partial class BalancoMensal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtValorTotRec = new Condominio.Util.TxtValor();
            this.label1 = new System.Windows.Forms.Label();
            this.listReceitas = new System.Windows.Forms.ListView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtValorTotDesp = new Condominio.Util.TxtValor();
            this.label2 = new System.Windows.Forms.Label();
            this.listDespesas = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBlancoTotal = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.labelAno = new System.Windows.Forms.Label();
            this.txtAno1 = new Condominio.Util.TxtAno();
            this.labelMes = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor1 = new Condominio.Util.TxtValor();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInicio);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1366, 666);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balanço Por Mês";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(1124, 596);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(231, 60);
            this.btnInicio.TabIndex = 10;
            this.btnInicio.Text = "Voltar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtValorTotRec);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.listReceitas);
            this.groupBox5.Location = new System.Drawing.Point(6, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1071, 313);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receitas: ";
            // 
            // txtValorTotRec
            // 
            this.txtValorTotRec.Enabled = false;
            this.txtValorTotRec.Location = new System.Drawing.Point(923, 64);
            this.txtValorTotRec.Name = "txtValorTotRec";
            this.txtValorTotRec.Size = new System.Drawing.Size(125, 34);
            this.txtValorTotRec.TabIndex = 2;
            this.txtValorTotRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(919, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Receitas";
            // 
            // listReceitas
            // 
            this.listReceitas.HideSelection = false;
            this.listReceitas.Location = new System.Drawing.Point(6, 33);
            this.listReceitas.Name = "listReceitas";
            this.listReceitas.Size = new System.Drawing.Size(907, 253);
            this.listReceitas.TabIndex = 0;
            this.listReceitas.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtValorTotDesp);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.listDespesas);
            this.groupBox6.Location = new System.Drawing.Point(0, 360);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1071, 306);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Despesas: ";
            // 
            // txtValorTotDesp
            // 
            this.txtValorTotDesp.Enabled = false;
            this.txtValorTotDesp.Location = new System.Drawing.Point(923, 58);
            this.txtValorTotDesp.Name = "txtValorTotDesp";
            this.txtValorTotDesp.Size = new System.Drawing.Size(125, 34);
            this.txtValorTotDesp.TabIndex = 3;
            this.txtValorTotDesp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(919, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Despesas";
            // 
            // listDespesas
            // 
            this.listDespesas.HideSelection = false;
            this.listDespesas.Location = new System.Drawing.Point(6, 33);
            this.listDespesas.Name = "listDespesas";
            this.listDespesas.Size = new System.Drawing.Size(907, 253);
            this.listDespesas.TabIndex = 1;
            this.listDespesas.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtBlancoTotal);
            this.groupBox4.Location = new System.Drawing.Point(1083, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 93);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Em Caixa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total:";
            // 
            // txtBlancoTotal
            // 
            this.txtBlancoTotal.Enabled = false;
            this.txtBlancoTotal.Location = new System.Drawing.Point(70, 40);
            this.txtBlancoTotal.Name = "txtBlancoTotal";
            this.txtBlancoTotal.Size = new System.Drawing.Size(137, 34);
            this.txtBlancoTotal.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboMes);
            this.groupBox3.Controls.Add(this.labelAno);
            this.groupBox3.Controls.Add(this.txtAno1);
            this.groupBox3.Controls.Add(this.labelMes);
            this.groupBox3.Controls.Add(this.btnConsultar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(1083, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 200);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Período";
            // 
            // comboMes
            // 
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(69, 33);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(152, 36);
            this.comboMes.TabIndex = 8;
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(7, 85);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(57, 28);
            this.labelAno.TabIndex = 7;
            this.labelAno.Text = "Ano: ";
            // 
            // txtAno1
            // 
            this.txtAno1.Location = new System.Drawing.Point(70, 82);
            this.txtAno1.Name = "txtAno1";
            this.txtAno1.Size = new System.Drawing.Size(79, 34);
            this.txtAno1.TabIndex = 6;
            this.txtAno1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(7, 36);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(57, 28);
            this.labelMes.TabIndex = 5;
            this.labelMes.Text = "Mês: ";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(69, 136);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 42);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtValor1);
            this.groupBox2.Location = new System.Drawing.Point(1083, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 133);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Valor R$:";
            // 
            // txtValor1
            // 
            this.txtValor1.Enabled = false;
            this.txtValor1.Location = new System.Drawing.Point(96, 61);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(125, 34);
            this.txtValor1.TabIndex = 3;
            this.txtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BalancoMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 680);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BalancoMensal";
            this.Text = "Balanço Mensal";
            this.Load += new System.EventHandler(this.BalancoMensal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listDespesas;
        private System.Windows.Forms.ListView listReceitas;
        private System.Windows.Forms.Label label3;
        private Util.TxtValor txtValor1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBlancoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelAno;
        private Util.TxtAno txtAno1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private Util.TxtValor txtValorTotRec;
        private System.Windows.Forms.Label label1;
        private Util.TxtValor txtValorTotDesp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInicio;
    }
}