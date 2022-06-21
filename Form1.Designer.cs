namespace MiniWord
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OPen = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italics = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.ComboBoxShrift = new System.Windows.Forms.ToolStripComboBox();
            this.Sizes = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPen,
            this.Save,
            this.Bold,
            this.Italics,
            this.Underline,
            this.ComboBoxShrift,
            this.Sizes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(687, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OPen
            // 
            this.OPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OPen.Image = ((System.Drawing.Image)(resources.GetObject("OPen.Image")));
            this.OPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OPen.Name = "OPen";
            this.OPen.Size = new System.Drawing.Size(23, 22);
            this.OPen.Text = "toolStripButton1";
            this.OPen.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "toolStripButton2";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 22);
            this.Bold.Text = "toolStripButton3";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italics
            // 
            this.Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italics.Image = ((System.Drawing.Image)(resources.GetObject("Italics.Image")));
            this.Italics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italics.Name = "Italics";
            this.Italics.Size = new System.Drawing.Size(23, 22);
            this.Italics.Text = "toolStripButton4";
            this.Italics.Click += new System.EventHandler(this.Italics_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = ((System.Drawing.Image)(resources.GetObject("Underline.Image")));
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(23, 22);
            this.Underline.Text = "toolStripButton5";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // ComboBoxShrift
            // 
            this.ComboBoxShrift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxShrift.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxShrift.Name = "ComboBoxShrift";
            this.ComboBoxShrift.Size = new System.Drawing.Size(200, 25);
            this.ComboBoxShrift.SelectedIndexChanged += new System.EventHandler(this.ComboBoxShrift_SelectedIndexChanged);
            // 
            // Sizes
            // 
            this.Sizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sizes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Sizes.Name = "Sizes";
            this.Sizes.Size = new System.Drawing.Size(75, 25);
            this.Sizes.SelectedIndexChanged += new System.EventHandler(this.Sizes_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbMessage
            // 
            this.tbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessage.Location = new System.Drawing.Point(0, 25);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(687, 293);
            this.tbMessage.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(687, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MiniText";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OPen;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italics;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripComboBox ComboBoxShrift;
        private System.Windows.Forms.ToolStripComboBox Sizes;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button button1;
    }
}
