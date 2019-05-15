namespace Demoexzamin
{
    partial class Zakazchik
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
            this.конструкторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изделиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тканиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фурнитураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спискиToolStripMenuItem,
            this.конструкторToolStripMenuItem,
            this.заказToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изделиеToolStripMenuItem,
            this.тканиToolStripMenuItem,
            this.фурнитураToolStripMenuItem,
            this.заказыToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(112, 33);
            this.спискиToolStripMenuItem.Text = "Списки";
            // 
            // конструкторToolStripMenuItem
            // 
            this.конструкторToolStripMenuItem.Name = "конструкторToolStripMenuItem";
            this.конструкторToolStripMenuItem.Size = new System.Drawing.Size(175, 33);
            this.конструкторToolStripMenuItem.Text = "Конструктор";
            // 
            // заказToolStripMenuItem
            // 
            this.заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            this.заказToolStripMenuItem.Size = new System.Drawing.Size(90, 33);
            this.заказToolStripMenuItem.Text = "Заказ";
            // 
            // изделиеToolStripMenuItem
            // 
            this.изделиеToolStripMenuItem.Name = "изделиеToolStripMenuItem";
            this.изделиеToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.изделиеToolStripMenuItem.Text = "Изделие";
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
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(224, 34);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // Zakazchik
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
            this.Name = "Zakazchik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма \"Заказчика\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zakazchik_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изделиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тканиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фурнитураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конструкторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem;
    }
}