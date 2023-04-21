
using Condominio.DAO;

namespace Condominio
{
    partial class TelaListaCondominos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaListaCondominos));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRegistrarPagamento = new System.Windows.Forms.Button();
            this.btnDebitoListCondomino = new System.Windows.Forms.Button();
            this.btnCopyTel = new System.Windows.Forms.Button();
            this.btnCopyEmail = new System.Windows.Forms.Button();
            this.btnBalanco = new System.Windows.Forms.Button();
            this.btnDespesas = new System.Windows.Forms.Button();
            this.btnNovoCondomino = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAlterarCondominio = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLancarDebAnual = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1167, 355);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(6, 32);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(220, 69);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar Cadastro";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRegistrarPagamento
            // 
            this.btnRegistrarPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPagamento.Image")));
            this.btnRegistrarPagamento.Location = new System.Drawing.Point(596, 32);
            this.btnRegistrarPagamento.Name = "btnRegistrarPagamento";
            this.btnRegistrarPagamento.Size = new System.Drawing.Size(262, 69);
            this.btnRegistrarPagamento.TabIndex = 2;
            this.btnRegistrarPagamento.Text = "Registrar Pagamento";
            this.btnRegistrarPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarPagamento.UseVisualStyleBackColor = true;
            this.btnRegistrarPagamento.Click += new System.EventHandler(this.btnRegistrarPagamento_Click);
            // 
            // btnDebitoListCondomino
            // 
            this.btnDebitoListCondomino.Image = ((System.Drawing.Image)(resources.GetObject("btnDebitoListCondomino.Image")));
            this.btnDebitoListCondomino.Location = new System.Drawing.Point(957, 32);
            this.btnDebitoListCondomino.Name = "btnDebitoListCondomino";
            this.btnDebitoListCondomino.Size = new System.Drawing.Size(203, 69);
            this.btnDebitoListCondomino.TabIndex = 3;
            this.btnDebitoListCondomino.Text = "Lançar Débito Específico";
            this.btnDebitoListCondomino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDebitoListCondomino.UseVisualStyleBackColor = true;
            this.btnDebitoListCondomino.Click += new System.EventHandler(this.btnDebitoListCondomino_Click);
            // 
            // btnCopyTel
            // 
            this.btnCopyTel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCopyTel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopyTel.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyTel.Image")));
            this.btnCopyTel.Location = new System.Drawing.Point(1181, 22);
            this.btnCopyTel.Name = "btnCopyTel";
            this.btnCopyTel.Size = new System.Drawing.Size(159, 55);
            this.btnCopyTel.TabIndex = 4;
            this.btnCopyTel.Text = "Copiar";
            this.btnCopyTel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCopyTel.UseVisualStyleBackColor = false;
            this.btnCopyTel.Click += new System.EventHandler(this.btnCopyTel_Click);
            // 
            // btnCopyEmail
            // 
            this.btnCopyEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCopyEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopyEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopyEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyEmail.Image")));
            this.btnCopyEmail.Location = new System.Drawing.Point(1181, 83);
            this.btnCopyEmail.Name = "btnCopyEmail";
            this.btnCopyEmail.Size = new System.Drawing.Size(159, 58);
            this.btnCopyEmail.TabIndex = 5;
            this.btnCopyEmail.Text = "Copiar";
            this.btnCopyEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCopyEmail.UseVisualStyleBackColor = false;
            this.btnCopyEmail.Click += new System.EventHandler(this.btnCopyEmail_Click);
            // 
            // btnBalanco
            // 
            this.btnBalanco.Image = ((System.Drawing.Image)(resources.GetObject("btnBalanco.Image")));
            this.btnBalanco.Location = new System.Drawing.Point(7, 33);
            this.btnBalanco.Name = "btnBalanco";
            this.btnBalanco.Size = new System.Drawing.Size(219, 69);
            this.btnBalanco.TabIndex = 6;
            this.btnBalanco.Text = "Balanço Mensal";
            this.btnBalanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBalanco.UseVisualStyleBackColor = true;
            this.btnBalanco.Click += new System.EventHandler(this.btnBalanco_Click);
            // 
            // btnDespesas
            // 
            this.btnDespesas.Image = ((System.Drawing.Image)(resources.GetObject("btnDespesas.Image")));
            this.btnDespesas.Location = new System.Drawing.Point(266, 33);
            this.btnDespesas.Name = "btnDespesas";
            this.btnDespesas.Size = new System.Drawing.Size(222, 69);
            this.btnDespesas.TabIndex = 7;
            this.btnDespesas.Text = "Depesas / Pagar Despesas";
            this.btnDespesas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDespesas.UseVisualStyleBackColor = true;
            this.btnDespesas.Click += new System.EventHandler(this.btnDespesas_Click);
            // 
            // btnNovoCondomino
            // 
            this.btnNovoCondomino.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCondomino.Image")));
            this.btnNovoCondomino.Location = new System.Drawing.Point(331, 32);
            this.btnNovoCondomino.Name = "btnNovoCondomino";
            this.btnNovoCondomino.Size = new System.Drawing.Size(169, 68);
            this.btnNovoCondomino.TabIndex = 8;
            this.btnNovoCondomino.Text = "Nova Casa";
            this.btnNovoCondomino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoCondomino.UseVisualStyleBackColor = true;
            this.btnNovoCondomino.Click += new System.EventHandler(this.btnNovoCondomino_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btnCopyTel);
            this.groupBox1.Controls.Add(this.btnCopyEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1346, 633);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condomínio Álvaro Moutinho";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLancarDebAnual);
            this.groupBox3.Controls.Add(this.btnAlterarCondominio);
            this.groupBox3.Controls.Add(this.btnBalanco);
            this.groupBox3.Controls.Add(this.btnDespesas);
            this.groupBox3.Location = new System.Drawing.Point(7, 515);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1167, 110);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestão do Condomínio";
            // 
            // btnAlterarCondominio
            // 
            this.btnAlterarCondominio.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarCondominio.Image")));
            this.btnAlterarCondominio.Location = new System.Drawing.Point(913, 33);
            this.btnAlterarCondominio.Name = "btnAlterarCondominio";
            this.btnAlterarCondominio.Size = new System.Drawing.Size(247, 69);
            this.btnAlterarCondominio.TabIndex = 8;
            this.btnAlterarCondominio.Text = "Alterar Condomínio";
            this.btnAlterarCondominio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarCondominio.UseVisualStyleBackColor = true;
            this.btnAlterarCondominio.Click += new System.EventHandler(this.btnAlterarCondominio_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAlterar);
            this.groupBox2.Controls.Add(this.btnNovoCondomino);
            this.groupBox2.Controls.Add(this.btnRegistrarPagamento);
            this.groupBox2.Controls.Add(this.btnDebitoListCondomino);
            this.groupBox2.Location = new System.Drawing.Point(7, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1166, 112);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moradores";
            // 
            // btnLancarDebAnual
            // 
            this.btnLancarDebAnual.Image = ((System.Drawing.Image)(resources.GetObject("btnLancarDebAnual.Image")));
            this.btnLancarDebAnual.Location = new System.Drawing.Point(547, 33);
            this.btnLancarDebAnual.Name = "btnLancarDebAnual";
            this.btnLancarDebAnual.Size = new System.Drawing.Size(311, 69);
            this.btnLancarDebAnual.TabIndex = 9;
            this.btnLancarDebAnual.Text = "Lançar Condomínio do Ano";
            this.btnLancarDebAnual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLancarDebAnual.UseVisualStyleBackColor = true;
            this.btnLancarDebAnual.Click += new System.EventHandler(this.btnLancarDebAnual_Click);
            // 
            // TelaListaCondominos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 680);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaListaCondominos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condôminos Cadastrados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaListaCondominos_FormClosed);
            this.Load += new System.EventHandler(this.TelaListaCondominos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRegistrarPagamento;
        private System.Windows.Forms.Button btnDebitoListCondomino;
        private System.Windows.Forms.Button btnCopyTel;
        private System.Windows.Forms.Button btnCopyEmail;
        private System.Windows.Forms.Button btnBalanco;
        private System.Windows.Forms.Button btnDespesas;
        private System.Windows.Forms.Button btnNovoCondomino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAlterarCondominio;
        private System.Windows.Forms.Button btnLancarDebAnual;
    }
}