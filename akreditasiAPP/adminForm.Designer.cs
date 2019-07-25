namespace akreditasiAPP
{
    partial class adminForm
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
            this.btLG = new System.Windows.Forms.Button();
            this.boxPass = new System.Windows.Forms.TextBox();
            this.boxID = new System.Windows.Forms.TextBox();
            this.btBK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "ADMIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOGIN";
            // 
            // btLG
            // 
            this.btLG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btLG.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLG.ForeColor = System.Drawing.Color.White;
            this.btLG.Location = new System.Drawing.Point(350, 311);
            this.btLG.Name = "btLG";
            this.btLG.Size = new System.Drawing.Size(100, 41);
            this.btLG.TabIndex = 8;
            this.btLG.Text = "LOGIN";
            this.btLG.UseVisualStyleBackColor = false;
            this.btLG.Click += new System.EventHandler(this.btLG_Click);
            // 
            // boxPass
            // 
            this.boxPass.Location = new System.Drawing.Point(285, 265);
            this.boxPass.Name = "boxPass";
            this.boxPass.Size = new System.Drawing.Size(235, 22);
            this.boxPass.TabIndex = 7;
            this.boxPass.UseSystemPasswordChar = true;
            this.boxPass.Enter += new System.EventHandler(this.boxPass_Enter);
            this.boxPass.Leave += new System.EventHandler(this.boxPass_Leave);
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(285, 220);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(235, 22);
            this.boxID.TabIndex = 6;
            this.boxID.Enter += new System.EventHandler(this.boxID_Enter);
            this.boxID.Leave += new System.EventHandler(this.boxID_Leave);
            // 
            // btBK
            // 
            this.btBK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btBK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBK.ForeColor = System.Drawing.Color.White;
            this.btBK.Location = new System.Drawing.Point(656, 384);
            this.btBK.Name = "btBK";
            this.btBK.Size = new System.Drawing.Size(100, 41);
            this.btBK.TabIndex = 12;
            this.btBK.Text = "BACK";
            this.btBK.UseVisualStyleBackColor = false;
            this.btBK.Click += new System.EventHandler(this.btBK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "PASSWORD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "USSERNAME :";
            // 
            // adminForm
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
            this.Controls.Add(this.btLG);
            this.Controls.Add(this.boxPass);
            this.Controls.Add(this.boxID);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLG;
        private System.Windows.Forms.TextBox boxPass;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Button btBK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}