namespace SiregarSport.View
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            this.persen = new System.Windows.Forms.Label();
            this.myProgres = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // persen
            // 
            this.persen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.persen.AutoSize = true;
            this.persen.BackColor = System.Drawing.Color.Transparent;
            this.persen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persen.ForeColor = System.Drawing.Color.White;
            this.persen.Location = new System.Drawing.Point(1007, 550);
            this.persen.Name = "persen";
            this.persen.Size = new System.Drawing.Size(66, 32);
            this.persen.TabIndex = 0;
            this.persen.Text = "%%";
            // 
            // myProgres
            // 
            this.myProgres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myProgres.BackColor = System.Drawing.Color.Transparent;
            this.myProgres.BorderRadius = 6;
            this.myProgres.FillColor = System.Drawing.Color.Black;
            this.myProgres.Location = new System.Drawing.Point(258, 589);
            this.myProgres.Name = "myProgres";
            this.myProgres.ProgressColor = System.Drawing.Color.White;
            this.myProgres.ProgressColor2 = System.Drawing.Color.White;
            this.myProgres.Size = new System.Drawing.Size(830, 21);
            this.myProgres.TabIndex = 1;
            this.myProgres.Text = "guna2ProgressBar1";
            this.myProgres.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading......";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1258, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myProgres);
            this.Controls.Add(this.persen);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label persen;
        private Guna.UI2.WinForms.Guna2ProgressBar myProgres;
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.Label label1;
    }
}