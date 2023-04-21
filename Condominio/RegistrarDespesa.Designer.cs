
namespace Condominio
{
    partial class RegistrarDespesa
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new Condominio.Util.TxtValor();
            this.button1 = new System.Windows.Forms.Button();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupUnica = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkUnica = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupMensal = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAno1 = new Condominio.Util.TxtAno();
            this.checkTodosMeses = new System.Windows.Forms.CheckBox();
            this.groupParcelamento = new System.Windows.Forms.GroupBox();
            this.checkParcelamento = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVencimento = new Condominio.Util.TxtQuantidade();
            this.txtParcelas = new Condominio.Util.TxtQuantidade();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new Condominio.Util.TxtValor();
            this.label7 = new System.Windows.Forms.Label();
            this.datePickerPagamento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupUnica.SuspendLayout();
            this.groupMensal.SuspendLayout();
            this.groupParcelamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.datePickerPagamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboMes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 649);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Despesas Registradas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total de Despesas:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(678, 581);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(125, 34);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Retirar Filtro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboMes
            // 
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(652, 39);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(151, 36);
            this.comboMes.TabIndex = 7;
            this.comboMes.SelectedIndexChanged += new System.EventHandler(this.comboMes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar por Mês:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(260, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nº - Descrição - Data - Valor";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(16, 101);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(476, 439);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(16, 568);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(299, 47);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Pagar Despesas Selecionadas";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupUnica);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.groupMensal);
            this.groupBox2.Controls.Add(this.groupParcelamento);
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Controls.Add(this.txtDescricao);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(842, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 649);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resgistrar Nova Despesa";
            // 
            // groupUnica
            // 
            this.groupUnica.Controls.Add(this.dateTimePicker1);
            this.groupUnica.Controls.Add(this.checkUnica);
            this.groupUnica.Controls.Add(this.label1);
            this.groupUnica.Location = new System.Drawing.Point(4, 422);
            this.groupUnica.Name = "groupUnica";
            this.groupUnica.Size = new System.Drawing.Size(439, 125);
            this.groupUnica.TabIndex = 27;
            this.groupUnica.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 34);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // checkUnica
            // 
            this.checkUnica.AutoSize = true;
            this.checkUnica.Location = new System.Drawing.Point(0, 0);
            this.checkUnica.Name = "checkUnica";
            this.checkUnica.Size = new System.Drawing.Size(160, 32);
            this.checkUnica.TabIndex = 20;
            this.checkUnica.Text = "Despesa Única";
            this.checkUnica.UseVisualStyleBackColor = true;
            this.checkUnica.CheckedChanged += new System.EventHandler(this.checkUnica_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(373, 574);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 47);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Voltar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupMensal
            // 
            this.groupMensal.Controls.Add(this.label6);
            this.groupMensal.Controls.Add(this.txtAno1);
            this.groupMensal.Controls.Add(this.checkTodosMeses);
            this.groupMensal.Location = new System.Drawing.Point(4, 269);
            this.groupMensal.Name = "groupMensal";
            this.groupMensal.Size = new System.Drawing.Size(439, 146);
            this.groupMensal.TabIndex = 26;
            this.groupMensal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ano:";
            // 
            // txtAno1
            // 
            this.txtAno1.Enabled = false;
            this.txtAno1.Location = new System.Drawing.Point(60, 58);
            this.txtAno1.Name = "txtAno1";
            this.txtAno1.Size = new System.Drawing.Size(85, 34);
            this.txtAno1.TabIndex = 18;
            this.txtAno1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkTodosMeses
            // 
            this.checkTodosMeses.AutoSize = true;
            this.checkTodosMeses.Location = new System.Drawing.Point(6, 0);
            this.checkTodosMeses.Name = "checkTodosMeses";
            this.checkTodosMeses.Size = new System.Drawing.Size(173, 32);
            this.checkTodosMeses.TabIndex = 20;
            this.checkTodosMeses.Text = "Despesa Mensal";
            this.checkTodosMeses.UseVisualStyleBackColor = true;
            this.checkTodosMeses.CheckedChanged += new System.EventHandler(this.checkTodosMeses_CheckedChanged);
            // 
            // groupParcelamento
            // 
            this.groupParcelamento.Controls.Add(this.checkParcelamento);
            this.groupParcelamento.Controls.Add(this.label9);
            this.groupParcelamento.Controls.Add(this.txtVencimento);
            this.groupParcelamento.Controls.Add(this.txtParcelas);
            this.groupParcelamento.Controls.Add(this.label8);
            this.groupParcelamento.Location = new System.Drawing.Point(7, 138);
            this.groupParcelamento.Name = "groupParcelamento";
            this.groupParcelamento.Size = new System.Drawing.Size(436, 125);
            this.groupParcelamento.TabIndex = 25;
            this.groupParcelamento.TabStop = false;
            // 
            // checkParcelamento
            // 
            this.checkParcelamento.AutoSize = true;
            this.checkParcelamento.Location = new System.Drawing.Point(0, 0);
            this.checkParcelamento.Name = "checkParcelamento";
            this.checkParcelamento.Size = new System.Drawing.Size(152, 32);
            this.checkParcelamento.TabIndex = 25;
            this.checkParcelamento.Text = "Parcelamento";
            this.checkParcelamento.UseVisualStyleBackColor = true;
            this.checkParcelamento.CheckStateChanged += new System.EventHandler(this.checkParcelamento_CheckStateChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "Parcelas:";
            // 
            // txtVencimento
            // 
            this.txtVencimento.Enabled = false;
            this.txtVencimento.Location = new System.Drawing.Point(193, 32);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.Size = new System.Drawing.Size(49, 34);
            this.txtVencimento.TabIndex = 22;
            this.txtVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParcelas
            // 
            this.txtParcelas.Enabled = false;
            this.txtParcelas.Location = new System.Drawing.Point(97, 78);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(49, 34);
            this.txtParcelas.TabIndex = 24;
            this.txtParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "Dia do Vencimento:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(183, 574);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(125, 39);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(124, 79);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(300, 34);
            this.txtDescricao.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descrição: ";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(124, 39);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 34);
            this.txtValor.TabIndex = 12;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Valor:";
            // 
            // datePickerPagamento
            // 
            this.datePickerPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerPagamento.Location = new System.Drawing.Point(669, 182);
            this.datePickerPagamento.Name = "datePickerPagamento";
            this.datePickerPagamento.Size = new System.Drawing.Size(149, 34);
            this.datePickerPagamento.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(502, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 71);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data de Registro do Pagamento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistrarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 680);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrarDespesa";
            this.Text = "Restrar Despesa";
            this.Load += new System.EventHandler(this.RegistrarDespesa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupUnica.ResumeLayout(false);
            this.groupUnica.PerformLayout();
            this.groupMensal.ResumeLayout(false);
            this.groupMensal.PerformLayout();
            this.groupParcelamento.ResumeLayout(false);
            this.groupParcelamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private Util.TxtValor txtValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private Util.TxtAno txtAno1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkTodosMeses;
        private Util.TxtQuantidade txtVencimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Util.TxtQuantidade txtParcelas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupUnica;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkUnica;
        private System.Windows.Forms.GroupBox groupMensal;
        private System.Windows.Forms.GroupBox groupParcelamento;
        private System.Windows.Forms.CheckBox checkParcelamento;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Util.TxtValor txtTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickerPagamento;
    }
}