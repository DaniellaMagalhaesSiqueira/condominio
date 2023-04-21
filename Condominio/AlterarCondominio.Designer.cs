
namespace Condominio
{
    partial class AlterarCondominio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCondominio));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtAtual = new Condominio.Util.TxtValor();
            this.txtAnterior = new Condominio.Util.TxtValor();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de Início de Vigência: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtAtual);
            this.groupBox1.Controls.Add(this.txtAnterior);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(197, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 442);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Condomínio";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(605, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 142);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ao alterar o valor do condomínio, todos os lançamentos de débitos de condomínio a" +
    " partir desta data serão lançados com o valor atual.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(820, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 58);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Voltar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtAtual
            // 
            this.txtAtual.Location = new System.Drawing.Point(153, 181);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.Size = new System.Drawing.Size(125, 34);
            this.txtAtual.TabIndex = 5;
            this.txtAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnterior
            // 
            this.txtAnterior.Enabled = false;
            this.txtAnterior.Location = new System.Drawing.Point(178, 111);
            this.txtAnterior.Name = "txtAnterior";
            this.txtAnterior.Size = new System.Drawing.Size(125, 34);
            this.txtAnterior.TabIndex = 3;
            this.txtAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(167, 278);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(145, 58);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Enviar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor Atual: R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Anterior: R$";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(261, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 34);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(605, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 108);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ao \"Lançar Condomínio do Ano\" na página inicial o valor Atual será lançado a cada" +
    " morador.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlterarCondominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 680);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlterarCondominio";
            this.Text = "Alterar Condomínio";
            this.Load += new System.EventHandler(this.AlterarCondominio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Util.TxtValor txtAtual;
        private Util.TxtValor txtAnterior;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}