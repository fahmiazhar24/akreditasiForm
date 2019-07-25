namespace akreditasiAPP
{
    partial class userForm
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
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxPass = new System.Windows.Forms.TextBox();
            this.btLG = new System.Windows.Forms.Button();
            this.btSG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btBK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(270, 203);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(235, 22);
            this.boxID.TabIndex = 0;
            this.boxID.Enter += new System.EventHandler(this.boxID_Enter);
            this.boxID.Leave += new System.EventHandler(this.boxID_Leave);
            // 
            // boxPass
            // 
            this.boxPass.Location = new System.Drawing.Point(270, 248);
            this.boxPass.Name = "boxPass";
            this.boxPass.Size = new System.Drawing.Size(235, 22);
            this.boxPass.TabIndex = 1;
            this.boxPass.Enter += new System.EventHandler(this.boxPass_Enter);
            this.boxPass.Leave += new System.EventHandler(this.boxPass_Leave);
            // 
            // btLG
            // 
            this.btLG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btLG.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLG.ForeColor = System.Drawing.Color.White;
            this.btLG.Location = new System.Drawing.Point(334, 292);
            this.btLG.Name = "btLG";
            this.btLG.Size = new System.Drawing.Size(111, 43);
            this.btLG.TabIndex = 2;
            this.btLG.Text = "LOGIN";
            this.btLG.UseVisualStyleBackColor = false;
            this.btLG.Click += new System.EventHandler(this.btLG_Click);
            // 
            // btSG
            // 
            this.btSG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btSG.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSG.ForeColor = System.Drawing.Color.White;
            this.btSG.Location = new System.Drawing.Point(322, 341);
            this.btSG.Name = "btSG";
            this.btSG.Size = new System.Drawing.Size(132, 43);
            this.btSG.TabIndex = 3;
            this.btSG.Text = "SIGN UP";
            this.btSG.UseVisualStyleBackColor = false;
            this.btSG.Click += new System.EventHandler(this.btSG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "USER";
            // 
            // btBK
            // 
            this.btBK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btBK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBK.ForeColor = System.Drawing.Color.White;
            this.btBK.Location = new System.Drawing.Point(677, 395);
            this.btBK.Name = "btBK";
            this.btBK.Size = new System.Drawing.Size(111, 43);
            this.btBK.TabIndex = 6;
            this.btBK.Text = "BACK";
            this.btBK.UseVisualStyleBackColor = false;
            this.btBK.Click += new System.EventHandler(this.btBK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "PASSWORD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "USSERNAME :";
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSG);
            this.Controls.Add(this.btLG);
            this.Controls.Add(this.boxPass);
            this.Controls.Add(this.boxID);
            this.Name = "userForm";
            this.Text = "userForm";
            this.Load += new System.EventHandler(this.userForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.TextBox boxPass;
        private System.Windows.Forms.Button btLG;
        private System.Windows.Forms.Button btSG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}