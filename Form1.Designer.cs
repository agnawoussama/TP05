
namespace TP05
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cmbxChercher = new System.Windows.Forms.ComboBox();
            this.btnChercher = new System.Windows.Forms.Button();
            this.txtbxChercher = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbxChercher);
            this.groupBox1.Controls.Add(this.btnChercher);
            this.groupBox1.Controls.Add(this.cmbxChercher);
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche Avancée";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 79);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(497, 260);
            this.dgv.TabIndex = 1;
            // 
            // cmbxChercher
            // 
            this.cmbxChercher.FormattingEnabled = true;
            this.cmbxChercher.Location = new System.Drawing.Point(14, 24);
            this.cmbxChercher.Name = "cmbxChercher";
            this.cmbxChercher.Size = new System.Drawing.Size(180, 28);
            this.cmbxChercher.TabIndex = 0;
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(362, 22);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(117, 31);
            this.btnChercher.TabIndex = 1;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // txtbxChercher
            // 
            this.txtbxChercher.Location = new System.Drawing.Point(230, 24);
            this.txtbxChercher.Name = "txtbxChercher";
            this.txtbxChercher.Size = new System.Drawing.Size(117, 28);
            this.txtbxChercher.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 351);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TP 05";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxChercher;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.ComboBox cmbxChercher;
        private System.Windows.Forms.DataGridView dgv;
    }
}

