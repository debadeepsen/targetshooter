namespace TargetShooter.UserControls
{
    partial class Target
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInner = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMid = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOuter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInner.SuspendLayout();
            this.btnMid.SuspendLayout();
            this.btnOuter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInner
            // 
            this.btnInner.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnInner.Controls.Add(this.label3);
            this.btnInner.Location = new System.Drawing.Point(73, 74);
            this.btnInner.Name = "btnInner";
            this.btnInner.Size = new System.Drawing.Size(51, 53);
            this.btnInner.TabIndex = 2;
            this.btnInner.Click += new System.EventHandler(this.btn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "100";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label_Click);
            // 
            // btnMid
            // 
            this.btnMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMid.Controls.Add(this.label2);
            this.btnMid.Location = new System.Drawing.Point(39, 40);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(120, 120);
            this.btnMid.TabIndex = 1;
            this.btnMid.Click += new System.EventHandler(this.btn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-1, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "50";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label_Click);
            // 
            // btnOuter
            // 
            this.btnOuter.BackColor = System.Drawing.Color.LightGreen;
            this.btnOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnOuter.Controls.Add(this.label1);
            this.btnOuter.Location = new System.Drawing.Point(3, 3);
            this.btnOuter.Name = "btnOuter";
            this.btnOuter.Size = new System.Drawing.Size(194, 194);
            this.btnOuter.TabIndex = 0;
            this.btnOuter.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "25";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label_Click);
            // 
            // Target
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnInner);
            this.Controls.Add(this.btnMid);
            this.Controls.Add(this.btnOuter);
            this.Name = "Target";
            this.Size = new System.Drawing.Size(200, 200);
            this.btnInner.ResumeLayout(false);
            this.btnMid.ResumeLayout(false);
            this.btnOuter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnOuter;
        private System.Windows.Forms.Panel btnMid;
        private System.Windows.Forms.Panel btnInner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
