namespace MissingParameterIdentifier
{
    partial class Missing_Parameter_Identifier
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
            this.process_final = new System.Windows.Forms.Button();
            this.openness_Excel = new System.Windows.Forms.Button();
            this.openness_Label = new System.Windows.Forms.Label();
            this.upload_Xmlfile = new System.Windows.Forms.Button();
            this.xml_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.XmlTextFile = new System.Windows.Forms.OpenFileDialog();
            this.opennessExcelfile = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.statusStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // process_final
            // 
            this.process_final.Location = new System.Drawing.Point(456, 279);
            this.process_final.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.process_final.Name = "process_final";
            this.process_final.Size = new System.Drawing.Size(114, 41);
            this.process_final.TabIndex = 21;
            this.process_final.Text = "Process";
            this.process_final.UseVisualStyleBackColor = true;
            this.process_final.Click += new System.EventHandler(this.process_final_Click);
            // 
            // openness_Excel
            // 
            this.openness_Excel.Location = new System.Drawing.Point(456, 188);
            this.openness_Excel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openness_Excel.Name = "openness_Excel";
            this.openness_Excel.Size = new System.Drawing.Size(113, 28);
            this.openness_Excel.TabIndex = 20;
            this.openness_Excel.Text = "Browse CSV File";
            this.openness_Excel.UseVisualStyleBackColor = true;
            this.openness_Excel.Click += new System.EventHandler(this.openness_Excel_Click);
            // 
            // openness_Label
            // 
            this.openness_Label.AutoSize = true;
            this.openness_Label.Location = new System.Drawing.Point(20, 161);
            this.openness_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.openness_Label.Name = "openness_Label";
            this.openness_Label.Size = new System.Drawing.Size(114, 13);
            this.openness_Label.TabIndex = 19;
            this.openness_Label.Text = "Upload CSV from TIA:-";
            // 
            // upload_Xmlfile
            // 
            this.upload_Xmlfile.Location = new System.Drawing.Point(456, 59);
            this.upload_Xmlfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upload_Xmlfile.Name = "upload_Xmlfile";
            this.upload_Xmlfile.Size = new System.Drawing.Size(113, 28);
            this.upload_Xmlfile.TabIndex = 18;
            this.upload_Xmlfile.Text = "Browse Xml File";
            this.upload_Xmlfile.UseVisualStyleBackColor = true;
            this.upload_Xmlfile.Click += new System.EventHandler(this.upload_Xmlfile_Click);
            // 
            // xml_Label
            // 
            this.xml_Label.AutoSize = true;
            this.xml_Label.Location = new System.Drawing.Point(20, 43);
            this.xml_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xml_Label.Name = "xml_Label";
            this.xml_Label.Size = new System.Drawing.Size(123, 13);
            this.xml_Label.TabIndex = 17;
            this.xml_Label.Text = "Openness Whitelist File:-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Missing Parameter Identifier";
            // 
            // XmlTextFile
            // 
            this.XmlTextFile.FileName = "openFileDialog1";
            // 
            // opennessExcelfile
            // 
            this.opennessExcelfile.FileName = "openFileDialog1";
            // 
            // statusStrip3
            // 
            this.statusStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip3.Location = new System.Drawing.Point(0, 344);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip3.Size = new System.Drawing.Size(600, 22);
            this.statusStrip3.TabIndex = 22;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 59);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 69);
            this.listBox1.TabIndex = 24;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(22, 188);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(386, 64);
            this.checkedListBox2.TabIndex = 23;
            // 
            // Missing_Parameter_Identifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.process_final);
            this.Controls.Add(this.openness_Excel);
            this.Controls.Add(this.openness_Label);
            this.Controls.Add(this.upload_Xmlfile);
            this.Controls.Add(this.xml_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Missing_Parameter_Identifier";
            this.Text = "Missing Parameter Identifier";
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button process_final;
        public System.Windows.Forms.Button openness_Excel;
        public System.Windows.Forms.Label openness_Label;
        public System.Windows.Forms.Button upload_Xmlfile;
        public System.Windows.Forms.Label xml_Label;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.OpenFileDialog XmlTextFile;
        public System.Windows.Forms.OpenFileDialog opennessExcelfile;
        public System.Windows.Forms.StatusStrip statusStrip3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}

