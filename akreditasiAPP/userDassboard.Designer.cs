namespace akreditasiAPP
{
    partial class userDassboard
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
            this.btLG = new System.Windows.Forms.Button();
            this.btViewAK = new System.Windows.Forms.Button();
            this.usUS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLG
            // 
            this.btLG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btLG.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLG.ForeColor = System.Drawing.Color.White;
            this.btLG.Location = new System.Drawing.Point(65, 272);
            this.btLG.Name = "btLG";
            this.btLG.Size = new System.Drawing.Size(199, 44);
            this.btLG.TabIndex = 9;
            this.btLG.Text = "LOGOUT";
            this.btLG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLG.UseVisualStyleBackColor = false;
            this.btLG.Click += new System.EventHandler(this.btLG_Click);
            // 
            // btViewAK
            // 
            this.btViewAK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btViewAK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewAK.ForeColor = System.Drawing.Color.White;
            this.btViewAK.Location = new System.Drawing.Point(65, 209);
            this.btViewAK.Name = "btViewAK";
            this.btViewAK.Size = new System.Drawing.Size(370, 44);
            this.btViewAK.TabIndex = 8;
            this.btViewAK.Text = "VIEW DATA AKREDITASI";
            this.btViewAK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btViewAK.UseVisualStyleBackColor = false;
            this.btViewAK.Click += new System.EventHandler(this.btViewAK_Click);
            // 
            // usUS
            // 
            this.usUS.AutoSize = true;
            this.usUS.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usUS.Location = new System.Drawing.Point(56, 139);
            this.usUS.Name = "usUS";
            this.usUS.Size = new System.Drawing.Size(330, 54);
            this.usUS.TabIndex = 6;
            this.usUS.Text = "USERNAME USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCOME";
            // 
            // userDassboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLG);
            this.Controls.Add(this.btViewAK);
            this.Controls.Add(this.usUS);
            this.Controls.Add(this.label1);
            this.Name = "userDassboard";
            this.Text = "userDassboard";
            this.Load += new System.EventHandler(this.userDassboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLG;
        private System.Windows.Forms.Button btViewAK;
        private System.Windows.Forms.Label usUS;
        private System.Windows.Forms.Label label1;
    }
}