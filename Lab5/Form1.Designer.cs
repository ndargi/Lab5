namespace Lab5
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OutlinecheckBox = new System.Windows.Forms.CheckBox();
            this.Fillcheckbox = new System.Windows.Forms.CheckBox();
            this.PenWidthListBox = new System.Windows.Forms.ListBox();
            this.FillcolorListbox = new System.Windows.Forms.ListBox();
            this.PencolorlistBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Draw_Box = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.TextradioButton = new System.Windows.Forms.RadioButton();
            this.EllipseradioButton = new System.Windows.Forms.RadioButton();
            this.RectangleradioButton = new System.Windows.Forms.RadioButton();
            this.Lineradiobutton = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.drawpanel = new System.Windows.Forms.Panel();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Draw_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(674, 40);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(169, 38);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.OutlinecheckBox);
            this.panel1.Controls.Add(this.Fillcheckbox);
            this.panel1.Controls.Add(this.PenWidthListBox);
            this.panel1.Controls.Add(this.FillcolorListbox);
            this.panel1.Controls.Add(this.PencolorlistBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Draw_Box);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 208);
            this.panel1.TabIndex = 2;
            this.panel1.Resize += new System.EventHandler(this.Form1_Load);
            // 
            // OutlinecheckBox
            // 
            this.OutlinecheckBox.AutoSize = true;
            this.OutlinecheckBox.Location = new System.Drawing.Point(370, 163);
            this.OutlinecheckBox.Name = "OutlinecheckBox";
            this.OutlinecheckBox.Size = new System.Drawing.Size(112, 29);
            this.OutlinecheckBox.TabIndex = 8;
            this.OutlinecheckBox.Text = "Outline";
            this.OutlinecheckBox.UseVisualStyleBackColor = true;
            // 
            // Fillcheckbox
            // 
            this.Fillcheckbox.AutoSize = true;
            this.Fillcheckbox.Location = new System.Drawing.Point(370, 133);
            this.Fillcheckbox.Name = "Fillcheckbox";
            this.Fillcheckbox.Size = new System.Drawing.Size(72, 29);
            this.Fillcheckbox.TabIndex = 7;
            this.Fillcheckbox.Text = "Fill";
            this.Fillcheckbox.UseVisualStyleBackColor = true;
            // 
            // PenWidthListBox
            // 
            this.PenWidthListBox.FormattingEnabled = true;
            this.PenWidthListBox.ItemHeight = 25;
            this.PenWidthListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PenWidthListBox.Location = new System.Drawing.Point(524, 38);
            this.PenWidthListBox.Name = "PenWidthListBox";
            this.PenWidthListBox.Size = new System.Drawing.Size(106, 154);
            this.PenWidthListBox.TabIndex = 6;
            // 
            // FillcolorListbox
            // 
            this.FillcolorListbox.FormattingEnabled = true;
            this.FillcolorListbox.ItemHeight = 25;
            this.FillcolorListbox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.FillcolorListbox.Location = new System.Drawing.Point(408, 38);
            this.FillcolorListbox.Name = "FillcolorListbox";
            this.FillcolorListbox.Size = new System.Drawing.Size(74, 79);
            this.FillcolorListbox.TabIndex = 5;
            // 
            // PencolorlistBox
            // 
            this.PencolorlistBox.FormattingEnabled = true;
            this.PencolorlistBox.ItemHeight = 25;
            this.PencolorlistBox.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.PencolorlistBox.Location = new System.Drawing.Point(295, 38);
            this.PencolorlistBox.Name = "PencolorlistBox";
            this.PencolorlistBox.Size = new System.Drawing.Size(74, 79);
            this.PencolorlistBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pen Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fill Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pen Color";
            // 
            // Draw_Box
            // 
            this.Draw_Box.Controls.Add(this.textBox);
            this.Draw_Box.Controls.Add(this.TextradioButton);
            this.Draw_Box.Controls.Add(this.EllipseradioButton);
            this.Draw_Box.Controls.Add(this.RectangleradioButton);
            this.Draw_Box.Controls.Add(this.Lineradiobutton);
            this.Draw_Box.Location = new System.Drawing.Point(27, 21);
            this.Draw_Box.Name = "Draw_Box";
            this.Draw_Box.Size = new System.Drawing.Size(201, 170);
            this.Draw_Box.TabIndex = 0;
            this.Draw_Box.TabStop = false;
            this.Draw_Box.Text = "Draw";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(20, 110);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(181, 60);
            this.textBox.TabIndex = 4;
            this.textBox.WordWrap = false;
            // 
            // TextradioButton
            // 
            this.TextradioButton.AutoSize = true;
            this.TextradioButton.Location = new System.Drawing.Point(20, 86);
            this.TextradioButton.Name = "TextradioButton";
            this.TextradioButton.Size = new System.Drawing.Size(85, 29);
            this.TextradioButton.TabIndex = 3;
            this.TextradioButton.TabStop = true;
            this.TextradioButton.Text = "Text";
            this.TextradioButton.UseVisualStyleBackColor = true;
            // 
            // EllipseradioButton
            // 
            this.EllipseradioButton.AutoSize = true;
            this.EllipseradioButton.Location = new System.Drawing.Point(20, 63);
            this.EllipseradioButton.Name = "EllipseradioButton";
            this.EllipseradioButton.Size = new System.Drawing.Size(107, 29);
            this.EllipseradioButton.TabIndex = 2;
            this.EllipseradioButton.TabStop = true;
            this.EllipseradioButton.Text = "Ellipse";
            this.EllipseradioButton.UseVisualStyleBackColor = true;
            // 
            // RectangleradioButton
            // 
            this.RectangleradioButton.AutoSize = true;
            this.RectangleradioButton.Location = new System.Drawing.Point(20, 39);
            this.RectangleradioButton.Name = "RectangleradioButton";
            this.RectangleradioButton.Size = new System.Drawing.Size(140, 29);
            this.RectangleradioButton.TabIndex = 1;
            this.RectangleradioButton.TabStop = true;
            this.RectangleradioButton.Text = "Rectangle";
            this.RectangleradioButton.UseVisualStyleBackColor = true;
            // 
            // Lineradiobutton
            // 
            this.Lineradiobutton.AutoSize = true;
            this.Lineradiobutton.Location = new System.Drawing.Point(20, 17);
            this.Lineradiobutton.Name = "Lineradiobutton";
            this.Lineradiobutton.Size = new System.Drawing.Size(84, 29);
            this.Lineradiobutton.TabIndex = 0;
            this.Lineradiobutton.TabStop = true;
            this.Lineradiobutton.Text = "Line";
            this.Lineradiobutton.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(645, 444);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 25);
            this.linkLabel1.TabIndex = 3;
            // 
            // drawpanel
            // 
            this.drawpanel.BackColor = System.Drawing.SystemColors.Window;
            this.drawpanel.Location = new System.Drawing.Point(0, 254);
            this.drawpanel.Name = "drawpanel";
            this.drawpanel.Size = new System.Drawing.Size(674, 279);
            this.drawpanel.TabIndex = 4;
            this.drawpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawpanel_Paint);
            this.drawpanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawpanel_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(674, 529);
            this.Controls.Add(this.drawpanel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Lab 5 - Nicholas Dargi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Draw_Box.ResumeLayout(false);
            this.Draw_Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Draw_Box;
        private System.Windows.Forms.RadioButton TextradioButton;
        private System.Windows.Forms.RadioButton EllipseradioButton;
        private System.Windows.Forms.RadioButton RectangleradioButton;
        private System.Windows.Forms.RadioButton Lineradiobutton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FillcolorListbox;
        private System.Windows.Forms.ListBox PencolorlistBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox PenWidthListBox;
        private System.Windows.Forms.CheckBox OutlinecheckBox;
        private System.Windows.Forms.CheckBox Fillcheckbox;
        private System.Windows.Forms.Panel drawpanel;
    }
}

