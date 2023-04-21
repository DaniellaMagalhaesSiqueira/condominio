
namespace Condominio
{
    partial class PagamentoCondomino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagamentoCondomino));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRepresentante = new System.Windows.Forms.Label();
            this.lbCasa = new System.Windows.Forms.Label();
            this.lbDebitoAtual = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfimarPagamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRepresentante);
            this.groupBox1.Controls.Add(this.lbCasa);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Condômino";
            // 
            // lbRepresentante
            // 
            this.lbRepresentante.AutoSize = true;
            this.lbRepresentante.Location = new System.Drawing.Point(7, 30);
            this.lbRepresentante.Name = "lbRepresentante";
            this.lbRepresentante.Size = new System.Drawing.Size(136, 28);
            this.lbRepresentante.TabIndex = 1;
            this.lbRepresentante.Text = "Representante";
            // 
            // lbCasa
            // 
            this.lbCasa.AutoSize = true;
            this.lbCasa.Location = new System.Drawing.Point(374, 30);
            this.lbCasa.Name = "lbCasa";
            this.lbCasa.Size = new System.Drawing.Size(52, 28);
            this.lbCasa.TabIndex = 0;
            this.lbCasa.Text = "Casa";
            // 
            // lbDebitoAtual
            // 
            this.lbDebitoAtual.AutoSize = true;
            this.lbDebitoAtual.Location = new System.Drawing.Point(6, 423);
            this.lbDebitoAtual.Name = "lbDebitoAtual";
            this.lbDebitoAtual.Size = new System.Drawing.Size(119, 28);
            this.lbDebitoAtual.TabIndex = 2;
            this.lbDebitoAtual.Text = "Débito Total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.lbDebitoAtual);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 468);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meses em Débito";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(7, 33);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(570, 352);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(123, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 75);
            this.label3.TabIndex = 6;
            this.label3.Text = "Será gerado um recibo no valor informado!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConfimarPagamento
            // 
            this.btnConfimarPagamento.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConfimarPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnConfimarPagamento.Image")));
            this.btnConfimarPagamento.Location = new System.Drawing.Point(206, 132);
            this.btnConfimarPagamento.Name = "btnConfimarPagamento";
            this.btnConfimarPagamento.Size = new System.Drawing.Size(214, 93);
            this.btnConfimarPagamento.TabIndex = 5;
            this.btnConfimarPagamento.Text = "Confirmar Pagamento";
            this.btnConfimarPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfimarPagamento.UseVisualStyleBackColor = true;
            this.btnConfimarPagamento.Click += new System.EventHandler(this.btnConfimarPagamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valores Calculados:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.txtValor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnConfimarPagamento);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(731, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 553);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar Pagamento";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(67, 374);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(496, 29);
            this.progressBar1.TabIndex = 11;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(269, 54);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(151, 34);
            this.txtValor.TabIndex = 10;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(1205, 577);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(137, 56);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // PagamentoCondomino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 703);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PagamentoCondomino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pagamento";
            this.Load += new System.EventHandler(this.PagamentoCondomino_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDebitoAtual;
        private System.Windows.Forms.Label lbRepresentante;
        private System.Windows.Forms.Label lbCasa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfimarPagamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnVoltar;
    }
}