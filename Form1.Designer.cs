namespace MySnake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameWindow = new System.Windows.Forms.PictureBox();
            this.Total = new System.Windows.Forms.Label();
            this.gameOwer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // gameWindow
            // 
            this.gameWindow.BackColor = System.Drawing.Color.Silver;
            this.gameWindow.Location = new System.Drawing.Point(10, 10);
            this.gameWindow.Name = "gameWindow";
            this.gameWindow.Size = new System.Drawing.Size(600, 600);
            this.gameWindow.TabIndex = 0;
            this.gameWindow.TabStop = false;
            this.gameWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.paintGraphics);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Silver;
            this.Total.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Total.ForeColor = System.Drawing.Color.Red;
            this.Total.Location = new System.Drawing.Point(298, 21);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(27, 20);
            this.Total.TabIndex = 2;
            this.Total.Text = "00";
            // 
            // gameOwer
            // 
            this.gameOwer.AutoSize = true;
            this.gameOwer.BackColor = System.Drawing.Color.Silver;
            this.gameOwer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameOwer.ForeColor = System.Drawing.Color.Red;
            this.gameOwer.Location = new System.Drawing.Point(249, 273);
            this.gameOwer.Name = "gameOwer";
            this.gameOwer.Size = new System.Drawing.Size(115, 25);
            this.gameOwer.TabIndex = 3;
            this.gameOwer.Text = "Game Ower";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 621);
            this.Controls.Add(this.gameOwer);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.gameWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox gameWindow;
        private Label Total;
        private Label gameOwer;
    }
}