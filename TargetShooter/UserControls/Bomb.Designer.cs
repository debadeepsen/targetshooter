namespace TargetShooter.UserControls
{
    partial class Bomb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bomb));
            this.imgBomb = new System.Windows.Forms.PictureBox();
            this.imgExplosion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExplosion)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBomb
            // 
            this.imgBomb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgBomb.BackgroundImage")));
            this.imgBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgBomb.Location = new System.Drawing.Point(84, 58);
            this.imgBomb.Name = "imgBomb";
            this.imgBomb.Size = new System.Drawing.Size(116, 128);
            this.imgBomb.TabIndex = 0;
            this.imgBomb.TabStop = false;
            this.imgBomb.Click += new System.EventHandler(this.imgBomb_Click);
            // 
            // imgExplosion
            // 
            this.imgExplosion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgExplosion.BackgroundImage")));
            this.imgExplosion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgExplosion.Location = new System.Drawing.Point(3, 3);
            this.imgExplosion.Name = "imgExplosion";
            this.imgExplosion.Size = new System.Drawing.Size(242, 191);
            this.imgExplosion.TabIndex = 1;
            this.imgExplosion.TabStop = false;
            this.imgExplosion.Visible = false;
            // 
            // Bomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.imgExplosion);
            this.Controls.Add(this.imgBomb);
            this.DoubleBuffered = true;
            this.Name = "Bomb";
            this.Size = new System.Drawing.Size(249, 197);
            ((System.ComponentModel.ISupportInitialize)(this.imgBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExplosion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBomb;
        private System.Windows.Forms.PictureBox imgExplosion;
    }
}
