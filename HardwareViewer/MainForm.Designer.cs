namespace HardwareViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lvHardware = new System.Windows.Forms.ListView();
            this.clHeaderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ckBoxShowNull = new System.Windows.Forms.CheckBox();
            this.cbBoxMajorWin32Class = new System.Windows.Forms.ComboBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxMinorWin32Class = new System.Windows.Forms.ComboBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBoxChildWin32Class = new System.Windows.Forms.ComboBox();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvHardware
            // 
            this.lvHardware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clHeaderItem,
            this.clHeaderValue});
            this.lvHardware.Location = new System.Drawing.Point(10, 6);
            this.lvHardware.Name = "lvHardware";
            this.lvHardware.Size = new System.Drawing.Size(821, 389);
            this.lvHardware.TabIndex = 1;
            this.lvHardware.UseCompatibleStateImageBehavior = false;
            this.lvHardware.View = System.Windows.Forms.View.Details;
            // 
            // clHeaderItem
            // 
            this.clHeaderItem.Text = "Item";
            this.clHeaderItem.Width = 300;
            // 
            // clHeaderValue
            // 
            this.clHeaderValue.Text = "Value";
            this.clHeaderValue.Width = 500;
            // 
            // ckBoxShowNull
            // 
            this.ckBoxShowNull.AutoSize = true;
            this.ckBoxShowNull.Checked = true;
            this.ckBoxShowNull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxShowNull.Location = new System.Drawing.Point(267, 108);
            this.ckBoxShowNull.Name = "ckBoxShowNull";
            this.ckBoxShowNull.Size = new System.Drawing.Size(347, 21);
            this.ckBoxShowNull.TabIndex = 4;
            this.ckBoxShowNull.Text = "The content does not display when empty.";
            this.ckBoxShowNull.UseVisualStyleBackColor = true;
            this.ckBoxShowNull.CheckedChanged += new System.EventHandler(this.ckBoxShowNull_CheckedChanged);
            // 
            // cbBoxMajorWin32Class
            // 
            this.cbBoxMajorWin32Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxMajorWin32Class.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBoxMajorWin32Class.FormattingEnabled = true;
            this.cbBoxMajorWin32Class.Location = new System.Drawing.Point(267, 8);
            this.cbBoxMajorWin32Class.Name = "cbBoxMajorWin32Class";
            this.cbBoxMajorWin32Class.Size = new System.Drawing.Size(561, 25);
            this.cbBoxMajorWin32Class.TabIndex = 3;
            this.cbBoxMajorWin32Class.SelectedIndexChanged += new System.EventHandler(this.cbBoxMajorWin32Class_SelectedIndexChanged);
            // 
            // pnl3
            // 
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl3.Location = new System.Drawing.Point(0, 532);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(841, 5);
            this.pnl3.TabIndex = 5;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.cbBoxChildWin32Class);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.cbBoxMinorWin32Class);
            this.pnl1.Controls.Add(this.ckBoxShowNull);
            this.pnl1.Controls.Add(this.cbBoxMajorWin32Class);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(841, 131);
            this.pnl1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Win32Classes Minor Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Win32Classes Major Category:";
            // 
            // cbBoxMinorWin32Class
            // 
            this.cbBoxMinorWin32Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxMinorWin32Class.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBoxMinorWin32Class.FormattingEnabled = true;
            this.cbBoxMinorWin32Class.Location = new System.Drawing.Point(267, 41);
            this.cbBoxMinorWin32Class.Name = "cbBoxMinorWin32Class";
            this.cbBoxMinorWin32Class.Size = new System.Drawing.Size(561, 25);
            this.cbBoxMinorWin32Class.TabIndex = 5;
            this.cbBoxMinorWin32Class.SelectedIndexChanged += new System.EventHandler(this.cbBoxMinorWin32Class_SelectedIndexChanged);
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.lvHardware);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(0, 131);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(841, 401);
            this.pnl2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Win32Classes Child Category:";
            // 
            // cbBoxChildWin32Class
            // 
            this.cbBoxChildWin32Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxChildWin32Class.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBoxChildWin32Class.FormattingEnabled = true;
            this.cbBoxChildWin32Class.Location = new System.Drawing.Point(267, 74);
            this.cbBoxChildWin32Class.Name = "cbBoxChildWin32Class";
            this.cbBoxChildWin32Class.Size = new System.Drawing.Size(561, 25);
            this.cbBoxChildWin32Class.TabIndex = 9;
            this.cbBoxChildWin32Class.SelectedIndexChanged += new System.EventHandler(this.cbBoxChildWin32Class_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(841, 537);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl3);
            this.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Computer Hardware Info - Zachary";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvHardware;
        private System.Windows.Forms.ColumnHeader clHeaderItem;
        private System.Windows.Forms.ColumnHeader clHeaderValue;
        private System.Windows.Forms.CheckBox ckBoxShowNull;
        private System.Windows.Forms.ComboBox cbBoxMajorWin32Class;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.ComboBox cbBoxMinorWin32Class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBoxChildWin32Class;
    }
}