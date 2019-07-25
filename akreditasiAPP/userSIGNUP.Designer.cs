namespace akreditasiAPP
{
    partial class userSIGNUP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSG = new System.Windows.Forms.Button();
            this.boxPass = new System.Windows.Forms.TextBox();
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxCnfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "SIGN UP";
            // 
            // btSG
            // 
            this.btSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btSG.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSG.ForeColor = System.Drawing.Color.White;
            this.btSG.Location = new System.Drawing.Point(328, 326);
            this.btSG.Name = "btSG";
            this.btSG.Size = new System.Drawing.Size(149, 41);
            this.btSG.TabIndex = 9;
            this.btSG.Text = "SIGN UP";
            this.btSG.UseVisualStyleBackColor = false;
            this.btSG.Click += new System.EventHandler(this.btSG_Click);
            // 
            // boxPass
            // 
            this.boxPass.Location = new System.Drawing.Point(285, 236);
            this.boxPass.Name = "boxPass";
            this.boxPass.Size = new System.Drawing.Size(235, 22);
            this.boxPass.TabIndex = 7;
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(285, 191);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(235, 22);
            this.boxID.TabIndex = 6;
            // 
            // boxCnfirm
            // 
            this.boxCnfirm.Location = new System.Drawing.Point(285, 281);
            this.boxCnfirm.Name = "boxCnfirm";
            this.boxCnfirm.Size = new System.Drawing.Size(235, 22);
            this.boxCnfirm.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "USSERNAME :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "PASSWORD :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "CONFIRM PASSWORD :";
            // 
            // userSIGNUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxCnfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSG);
            this.Controls.Add(this.boxPass);
            this.Controls.Add(this.boxID);
            this.Name = "userSIGNUP";
            this.Text = "userSIGNUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSG;
        private System.Windows.Forms.TextBox boxPass;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.TextBox boxCnfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}