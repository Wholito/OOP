namespace OOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            SaveButton = new ToolStripMenuItem();
            LoadButton = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            CanselButton = new ToolStripMenuItem();
            Return = new ToolStripMenuItem();
            InfoButton = new ToolStripMenuItem();
            AddPlaginButton = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            LineButton = new ToolStripButton();
            RectangleButton = new ToolStripButton();
            CircleButton = new ToolStripButton();
            BrokenLineButton = new ToolStripButton();
            polygonButton = new ToolStripButton();
            BrushThiknessButton = new ToolStripButton();
            BrushColorButton = new ToolStripButton();
            FillButton = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, InfoButton, AddPlaginButton });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1369, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveButton, LoadButton });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveButton
            // 
            SaveButton.Name = "SaveButton";
            SaveButton.ShortcutKeyDisplayString = "Ctrl + S";
            SaveButton.Size = new Size(179, 22);
            SaveButton.Text = "Сохранить";
            // 
            // LoadButton
            // 
            LoadButton.Name = "LoadButton";
            LoadButton.ShortcutKeyDisplayString = "Ctrl + O";
            LoadButton.Size = new Size(179, 22);
            LoadButton.Text = "Загрузить";
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CanselButton, Return });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // CanselButton
            // 
            CanselButton.Name = "CanselButton";
            CanselButton.ShortcutKeyDisplayString = "Ctrl + Z";
            CanselButton.Size = new Size(175, 22);
            CanselButton.Text = "Отменить";
            // 
            // Return
            // 
            Return.Name = "Return";
            Return.ShortcutKeyDisplayString = "Ctrl + R";
            Return.Size = new Size(175, 22);
            Return.Text = "Вернуть";
            // 
            // InfoButton
            // 
            InfoButton.Name = "InfoButton";
            InfoButton.Size = new Size(65, 20);
            InfoButton.Text = "Справка";
            InfoButton.Click += InfoButton_Click;
            // 
            // AddPlaginButton
            // 
            AddPlaginButton.Name = "AddPlaginButton";
            AddPlaginButton.Size = new Size(113, 20);
            AddPlaginButton.Text = "Добавить плагин";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.Items.AddRange(new ToolStripItem[] { LineButton, RectangleButton, CircleButton, BrokenLineButton, polygonButton, BrushThiknessButton, BrushColorButton, FillButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(32, 551);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // LineButton
            // 
            LineButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            LineButton.Image = (Image)resources.GetObject("LineButton.Image");
            LineButton.ImageTransparentColor = Color.Magenta;
            LineButton.Name = "LineButton";
            LineButton.Size = new Size(29, 20);
            LineButton.Text = "toolStripButton1";
            LineButton.Click += LineButton_Click;
            // 
            // RectangleButton
            // 
            RectangleButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            RectangleButton.Image = (Image)resources.GetObject("RectangleButton.Image");
            RectangleButton.ImageTransparentColor = Color.Magenta;
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(29, 20);
            RectangleButton.Text = "Rectangle";
            RectangleButton.Click += RectangleButton_Click;
            // 
            // CircleButton
            // 
            CircleButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            CircleButton.Image = (Image)resources.GetObject("CircleButton.Image");
            CircleButton.ImageTransparentColor = Color.Magenta;
            CircleButton.Name = "CircleButton";
            CircleButton.Size = new Size(29, 20);
            CircleButton.Text = "toolStripButton2";
            CircleButton.Click += CircleButton_Click;
            // 
            // BrokenLineButton
            // 
            BrokenLineButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BrokenLineButton.Image = (Image)resources.GetObject("BrokenLineButton.Image");
            BrokenLineButton.ImageTransparentColor = Color.Magenta;
            BrokenLineButton.Name = "BrokenLineButton";
            BrokenLineButton.Size = new Size(29, 20);
            BrokenLineButton.Text = "toolStripButton3";
            BrokenLineButton.Click += BrokenLineButton_Click;
            // 
            // polygonButton
            // 
            polygonButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            polygonButton.Image = (Image)resources.GetObject("polygonButton.Image");
            polygonButton.ImageTransparentColor = Color.Magenta;
            polygonButton.Name = "polygonButton";
            polygonButton.Size = new Size(29, 20);
            polygonButton.Text = "toolStripButton4";
            polygonButton.Click += polygonButton_Click_1;
            // 
            // BrushThiknessButton
            // 
            BrushThiknessButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BrushThiknessButton.Image = (Image)resources.GetObject("BrushThiknessButton.Image");
            BrushThiknessButton.ImageTransparentColor = Color.Magenta;
            BrushThiknessButton.Name = "BrushThiknessButton";
            BrushThiknessButton.Size = new Size(29, 20);
            BrushThiknessButton.Text = "toolStripButton5";
            BrushThiknessButton.Click += BrushThiknessButton_Click;
            // 
            // BrushColorButton
            // 
            BrushColorButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BrushColorButton.Image = (Image)resources.GetObject("BrushColorButton.Image");
            BrushColorButton.ImageTransparentColor = Color.Magenta;
            BrushColorButton.Name = "BrushColorButton";
            BrushColorButton.Size = new Size(29, 20);
            BrushColorButton.Text = "toolStripButton6";
            BrushColorButton.Click += BrushColorButton_Click;
            // 
            // FillButton
            // 
            FillButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            FillButton.Image = (Image)resources.GetObject("FillButton.Image");
            FillButton.ImageTransparentColor = Color.Magenta;
            FillButton.Name = "FillButton";
            FillButton.Size = new Size(29, 20);
            FillButton.Text = "toolStripButton7";
            FillButton.Click += FillButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1369, 575);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OOP";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem SaveButton;
        private ToolStripMenuItem LoadButton;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem CanselButton;
        private ToolStripMenuItem Return;
        private ToolStripMenuItem InfoButton;
        private ToolStrip toolStrip1;
        private ToolStripButton RectangleButton;
        private ToolStripButton CircleButton;
        private ToolStripButton BrokenLineButton;
        private ToolStripButton polygonButton;
        private ToolStripButton BrushThiknessButton;
        private ToolStripButton BrushColorButton;
        private ToolStripButton FillButton;
        private ToolStripMenuItem AddPlaginButton;
        private ToolStripButton LineButton;
    }
}