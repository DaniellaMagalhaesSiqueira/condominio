
namespace Condominio
{
    partial class LancamentoDebitoAnual
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtAno1 = new Condominio.Util.TxtAno();
            this.btnLancarDespesaAnual = new System.Windows.Forms.Button();
            this.labelAno = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.txtAno1);
            this.groupBox1.Controls.Add(this.btnLancarDespesaAnual);
            this.groupBox1.Controls.Add(this.labelAno);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(386, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 311);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lançamento Anual de Débitos";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(262, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 29);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // txtAno1
            // 
            this.txtAno1.Location = new System.Drawing.Point(90, 56);
            this.txtAno1.Name = "txtAno1";
            this.txtAno1.Size = new System.Drawing.Size(125, 47);
            this.txtAno1.TabIndex = 3;
            this.txtAno1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLancarDespesaAnual
            // 
            this.btnLancarDespesaAnual.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLancarDespesaAnual.Location = new System.Drawing.Point(35, 171);
            this.btnLancarDespesaAnual.Name = "btnLancarDespesaAnual";
            this.btnLancarDespesaAnual.Size = new System.Drawing.Size(374, 91);
            this.btnLancarDespesaAnual.TabIndex = 2;
            this.btnLancarDespesaAnual.Text = "Lançar Débito Anual de Condôminos";
            this.btnLancarDespesaAnual.UseVisualStyleBackColor = true;
            this.btnLancarDespesaAnual.Click += new System.EventHandler(this.btnLancarDespesaAnual_Click);
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAno.Location = new System.Drawing.Point(35, 63);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(48, 28);
            this.labelAno.TabIndex = 0;
            this.labelAno.Text = "Ano";
            // 
            // LancamentoDebitoAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 680);
            this.Controls.Add(this.groupBox1);
            this.Name = "LancamentoDebitoAnual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LancamentoDebitoAnual";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Button btnLancarDespesaAnual;
        private Util.TxtAno txtAno1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}