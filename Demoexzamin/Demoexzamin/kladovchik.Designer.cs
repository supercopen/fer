namespace Demoexzamin
{
    partial class kladovchik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тканиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фурнитураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спискиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тканиToolStripMenuItem,
            this.фурнитураToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(112, 33);
            this.спискиToolStripMenuItem.Text = "Списки";
            // 
            // тканиToolStripMenuItem
            // 
            this.тканиToolStripMenuItem.Name = "тканиToolStripMenuItem";
            this.тканиToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.тканиToolStripMenuItem.Text = "Ткани";
            // 
            // фурнитураToolStripMenuItem
            // 
            this.фурнитураToolStripMenuItem.Name = "фурнитураToolStripMenuItem";
            this.фурнитураToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.фурнитураToolStripMenuItem.Text = "Фурнитура";
            // 
            // kladovchik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 449);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kladovchik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма \"Кладовщик\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kladovchik_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тканиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фурнитураToolStripMenuItem;
    }
}