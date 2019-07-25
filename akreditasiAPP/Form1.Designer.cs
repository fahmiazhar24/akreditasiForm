namespace akreditasiAPP
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnADM = new System.Windows.Forms.Button();
            this.btnMHS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(290, 95);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(197, 46);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "AKREDITASI";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(253, 141);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(282, 46);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "PROGRAM STUDI";
            // 
            // btnADM
            // 
            this.btnADM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnADM.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADM.ForeColor = System.Drawing.Color.White;
            this.btnADM.Location = new System.Drawing.Point(292, 217);
            this.btnADM.Name = "btnADM";
            this.btnADM.Size = new System.Drawing.Size(195, 46);
            this.btnADM.TabIndex = 2;
            this.btnADM.Text = "ADMIN";
            this.btnADM.UseVisualStyleBackColor = false;
            this.btnADM.Click += new System.EventHandler(this.btnADM_Click);
            // 
            // btnMHS
            // 
            this.btnMHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnMHS.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMHS.ForeColor = System.Drawing.Color.White;
            this.btnMHS.Location = new System.Drawing.Point(292, 284);
            this.btnMHS.Name = "btnMHS";
            this.btnMHS.Size = new System.Drawing.Size(195, 46);
            this.btnMHS.TabIndex = 3;
            this.btnMHS.Text = "USER";
            this.btnMHS.UseVisualStyleBackColor = false;
            this.btnMHS.Click += new System.EventHandler(this.btnMHS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMHS);
            this.Controls.Add(this.btnADM);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnADM;
        private System.Windows.Forms.Button btnMHS;
    }
}

