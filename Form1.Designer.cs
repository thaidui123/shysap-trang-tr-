namespace shysap_trang_trí
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.lbsketqua = new System.Windows.Forms.ListBox();
            this.btntim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kết quả";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(188, 54);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(109, 20);
            this.txtnam.TabIndex = 2;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(188, 100);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(109, 20);
            this.txtketqua.TabIndex = 2;
            // 
            // lbsketqua
            // 
            this.lbsketqua.FormattingEnabled = true;
            this.lbsketqua.Location = new System.Drawing.Point(482, 74);
            this.lbsketqua.Name = "lbsketqua";
            this.lbsketqua.Size = new System.Drawing.Size(286, 290);
            this.lbsketqua.TabIndex = 3;
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntim.Location = new System.Drawing.Point(342, 65);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 43);
            this.btntim.TabIndex = 4;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.lbsketqua);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.ListBox lbsketqua;
        private System.Windows.Forms.Button btntim;
    }
}

