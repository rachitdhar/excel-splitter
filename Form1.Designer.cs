namespace massive_sheet_splitter
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
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btn_select = new Button();
            btn_split = new Button();
            num_headers = new NumericUpDown();
            label3 = new Label();
            tb_file_loc = new TextBox();
            tb_download_loc = new TextBox();
            btn_browse = new Button();
            label2 = new Label();
            tb_split_num = new TextBox();
            lbl_split_by = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)num_headers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 0;
            label1.Text = "Number of Header Rows";
            // 
            // btn_select
            // 
            btn_select.Location = new Point(479, 78);
            btn_select.Margin = new Padding(4, 5, 4, 5);
            btn_select.Name = "btn_select";
            btn_select.Size = new Size(107, 38);
            btn_select.TabIndex = 1;
            btn_select.Text = "Select";
            btn_select.UseVisualStyleBackColor = true;
            btn_select.Click += btn_select_Click;
            // 
            // btn_split
            // 
            btn_split.Location = new Point(256, 338);
            btn_split.Margin = new Padding(4, 5, 4, 5);
            btn_split.Name = "btn_split";
            btn_split.Size = new Size(107, 38);
            btn_split.TabIndex = 2;
            btn_split.Text = "Split";
            btn_split.UseVisualStyleBackColor = true;
            btn_split.Click += btn_split_Click;
            // 
            // num_headers
            // 
            num_headers.Location = new Point(243, 30);
            num_headers.Margin = new Padding(4, 5, 4, 5);
            num_headers.Name = "num_headers";
            num_headers.Size = new Size(86, 31);
            num_headers.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 83);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 7;
            label3.Text = "File to Split";
            // 
            // tb_file_loc
            // 
            tb_file_loc.Enabled = false;
            tb_file_loc.Location = new Point(243, 78);
            tb_file_loc.Margin = new Padding(4, 5, 4, 5);
            tb_file_loc.Name = "tb_file_loc";
            tb_file_loc.Size = new Size(225, 31);
            tb_file_loc.TabIndex = 8;
            // 
            // tb_download_loc
            // 
            tb_download_loc.Enabled = false;
            tb_download_loc.Location = new Point(243, 127);
            tb_download_loc.Margin = new Padding(4, 5, 4, 5);
            tb_download_loc.Name = "tb_download_loc";
            tb_download_loc.Size = new Size(225, 31);
            tb_download_loc.TabIndex = 11;
            // 
            // btn_browse
            // 
            btn_browse.Location = new Point(479, 127);
            btn_browse.Margin = new Padding(4, 5, 4, 5);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(107, 38);
            btn_browse.TabIndex = 10;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = true;
            btn_browse.Click += btn_browse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 9;
            label2.Text = "Download Location";
            // 
            // tb_split_num
            // 
            tb_split_num.Location = new Point(256, 285);
            tb_split_num.Margin = new Padding(4, 5, 4, 5);
            tb_split_num.Name = "tb_split_num";
            tb_split_num.Size = new Size(105, 31);
            tb_split_num.TabIndex = 12;
            // 
            // lbl_split_by
            // 
            lbl_split_by.AutoSize = true;
            lbl_split_by.Location = new Point(30, 290);
            lbl_split_by.Margin = new Padding(4, 0, 4, 0);
            lbl_split_by.Name = "lbl_split_by";
            lbl_split_by.Size = new Size(147, 25);
            lbl_split_by.TabIndex = 13;
            lbl_split_by.Text = "Max rows per file";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(30, 217);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(182, 29);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Split by Max Rows";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(256, 217);
            radioButton2.Margin = new Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(198, 29);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "Split by File Number";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(394, 285);
            progressBar1.Margin = new Padding(4, 5, 4, 5);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(191, 38);
            progressBar1.TabIndex = 16;
            progressBar1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 397);
            Controls.Add(progressBar1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lbl_split_by);
            Controls.Add(tb_split_num);
            Controls.Add(tb_download_loc);
            Controls.Add(btn_browse);
            Controls.Add(label2);
            Controls.Add(tb_file_loc);
            Controls.Add(label3);
            Controls.Add(num_headers);
            Controls.Add(btn_split);
            Controls.Add(btn_select);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Excel Splitter";
            ((System.ComponentModel.ISupportInitialize)num_headers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btn_select;
        private Button btn_split;
        private NumericUpDown num_headers;
        private Label label3;
        private TextBox tb_file_loc;
        private TextBox tb_download_loc;
        private Button btn_browse;
        private Label label2;
        private TextBox tb_split_num;
        private Label lbl_split_by;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private OpenFileDialog openFileDialog1;
        private ProgressBar progressBar1;
    }
}
