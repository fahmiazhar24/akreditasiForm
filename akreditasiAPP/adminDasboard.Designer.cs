namespace akreditasiAPP
{
    partial class adminDasboard
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
            this.usADM = new System.Windows.Forms.Label();
            this.btInputAK = new System.Windows.Forms.Button();
            this.btViewAK = new System.Windows.Forms.Button();
            this.btLG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME";
            // 
            // usADM
            // 
            this.usADM.AutoSize = true;
            this.usADM.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usADM.Location = new System.Drawing.Point(52, 136);
            this.usADM.Name = "usADM";
            this.usADM.Size = new System.Drawing.Size(369, 54);
            this.usADM.TabIndex = 1;
            this.usADM.Text = "USERNAME ADMIN";
            // 
            // btInputAK
            // 
            this.btInputAK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btInputAK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInputAK.ForeColor = System.Drawing.Color.White;
            this.btInputAK.Location = new System.Drawing.Point(61, 194);
            this.btInputAK.Name = "btInputAK";
            this.btInputAK.Size = new System.Drawing.Size(370, 44);
            this.btInputAK.TabIndex = 2;
            this.btInputAK.Text = "INPUT DATA AKREDITASI";
            this.btInputAK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInputAK.UseVisualStyleBackColor = false;
            this.btInputAK.Click += new System.EventHandler(this.btInputAK_Click);
            // 
            // btViewAK
            // 
            this.btViewAK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btViewAK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewAK.ForeColor = System.Drawing.Color.White;
            this.btViewAK.Location = new System.Drawing.Point(61, 253);
            this.btViewAK.Name = "btViewAK";
            this.btViewAK.Size = new System.Drawing.Size(370, 44);
            this.btViewAK.TabIndex = 3;
            this.btViewAK.Text = "VIEW DATA AKREDITASI";
            this.btViewAK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btViewAK.UseVisualStyleBackColor = false;
            // 
            // btLG
            // 
            this.btLG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btLG.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLG.ForeColor = System.Drawing.Color.White;
            this.btLG.Location = new System.Drawing.Point(61, 316);
            this.btLG.Name = "btLG";
            this.btLG.Size = new System.Drawing.Size(199, 44);
            this.btLG.TabIndex = 4;
            this.btLG.Text = "LOGOUT";
            this.btLG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLG.UseVisualStyleBackColor = false;
            this.btLG.Click += new System.EventHandler(this.btLG_Click);
            // 
            // adminDasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLG);
            this.Controls.Add(this.btViewAK);
            this.Controls.Add(this.btInputAK);
            this.Controls.Add(this.usADM);
            this.Controls.Add(this.label1);
            this.Name = "adminDasboard";
            this.Text = "adminDasboard";
            this.Load += new System.EventHandler(this.adminDasboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usADM;
        private System.Windows.Forms.Button btInputAK;
        private System.Windows.Forms.Button btViewAK;
        private System.Windows.Forms.Button btLG;
    }
}