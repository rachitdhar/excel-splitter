using System.ComponentModel;

namespace massive_sheet_splitter
{
    public partial class Form1 : Form
    {
        private ExcelHelper excelHelper;
        private string file_location = "";
        private string download_location = "";
        private bool split_by_rows = true;

        public Form1()
        {
            InitializeComponent();
            excelHelper = new ExcelHelper();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                lbl_split_by.Text = "Max rows per file";
                split_by_rows = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                lbl_split_by.Text = "Number of files";
                split_by_rows = false;
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Select a folder to save your files";
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                download_location = folderBrowserDialog1.SelectedPath;
                tb_download_loc.Text = download_location;
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Choose file to be split";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_location = openFileDialog1.FileName;
                tb_file_loc.Text = file_location;
            }
        }

        private void btn_split_Click(object sender, EventArgs e)
        {
            int split_num = 0;
            if (
                string.IsNullOrEmpty(tb_file_loc.Text) ||
                string.IsNullOrEmpty(tb_download_loc.Text) ||
                string.IsNullOrEmpty(tb_split_num.Text) ||
                !int.TryParse(tb_split_num.Text, out split_num) ||
                split_num < 0
            )
            {
                MessageBox.Show("Please fill all the fields correctly.");
                return;
            }

            if (!tb_file_loc.Text.EndsWith(".xlsx"))
            {
                MessageBox.Show("Please select a .xlsx file only.");
                return;
            }

            try
            {
                btn_split.Enabled = false;
                List<ExcelSheetData> data = excelHelper.read_excel(tb_file_loc.Text);
                int max_total_rows = excelHelper.GetSheetWithMostRows(data).RowCount;
                int max_rows = (split_by_rows) ? split_num : (max_total_rows / split_num) + 1;
                int total_files = (max_total_rows / max_rows) + ((max_total_rows % max_rows) > 0 ? 1 : 0);

                int header_rows = (int)num_headers.Value;
                int curr_row = header_rows + 1;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;
                progressBar1.Step = 100 / total_files;
                progressBar1.Visible = true;

                for (int file_num = 0; file_num < total_files; file_num++)
                {
                    string new_file_name = $"split_sheet_{file_num + 1}.xlsx";
                    string new_file_path = System.IO.Path.Combine(download_location, new_file_name);
                    excelHelper.write_excel(new_file_path, data, curr_row, curr_row + max_rows, header_rows);
                    curr_row += max_rows;
                    progressBar1.PerformStep();
                }

                progressBar1.Value = 100;
                MessageBox.Show("Completed successfully!");
                btn_split.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to split.");
                btn_split.Enabled = true;
            }
        }
    }
}
