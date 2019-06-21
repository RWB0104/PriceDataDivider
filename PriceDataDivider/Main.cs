using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace PriceDataDivider
{
    public partial class Main : Form
    {
        string filePath = null;
        string savePath = null;
        string extension = null;
        string dateStamp = DateTime.Now.ToString("yyMMdd");

        public Main()
        {
            InitializeComponent();

            radioButtonAuto.Checked = true;
            radioButtonXLSX.Checked = true;

            textBoxNum.Text = "30000";
            textBoxSave.Enabled = false;
            buttonSave.Enabled = false;

            CheckForIllegalCrossThreadCalls = false;
        }

        private void TextBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
                e.Handled = true;
        }

        private void RadioButtonAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAuto.Checked)
            {
                savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\공시지가_" + dateStamp;
                textBoxSave.Enabled = false;
                buttonSave.Enabled = false;
            }

            else
            {
                savePath = textBoxSave.Text;
                textBoxSave.Enabled = true;
                buttonSave.Enabled = true;
            }
        }

        private void RadioButtonXLSX_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonXLSX.Checked)
                extension = "xlsx";

            else
                extension = "xls";
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Files|*.xls; *.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog.FileName;
                filePath = openFileDialog.FileName;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSave.Text = folderBrowserDialog.SelectedPath;
                savePath = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            labelProgress.Text = "작업 준비중...";

            DirectoryInfo directoryInfo = new DirectoryInfo(savePath);

            if (!directoryInfo.Exists)
                directoryInfo.Create();

            Excel.Application OriginApp = new Excel.Application
            {
                Visible = false,
                DisplayAlerts = false,
                Interactive = false
            };

            Excel.Workbook OriginBook = OriginApp.Workbooks.Open(filePath);
            Excel.Worksheet OriginSheet = OriginBook.ActiveSheet;

            int excelEnd = OriginSheet.UsedRange.Rows.Count;
            int cnt = Convert.ToInt32(textBoxNum.Text);

            double excelEnd_double = OriginSheet.UsedRange.Rows.Count;
            double cnt_double = Convert.ToInt32(textBoxNum.Text);

            int size = Label(excelEnd_double, cnt_double);

            progressBar.Maximum = size;

            if (OriginApp == null)
            {
                MessageBox.Show("Excel을 정상적으로 사용할 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int j = 1;

            for (int i = 2; i <= excelEnd; i += cnt)
            {
                Excel.Application ExcelApp = new Excel.Application
                {
                    Visible = false,
                    DisplayAlerts = false,
                    Interactive = false
                };

                Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet ExcelSheet = ExcelBook.ActiveSheet;
                Excel.Range ExcelRange = ExcelSheet.Range["A2:B" + (cnt + 1)];

                ExcelSheet.Cells[1, 1] = "ADDRESS";
                ExcelSheet.Cells[1, 2] = "JIGA";

                string start = "A" + Convert.ToString(i);
                string end = "B" + Convert.ToString(i + cnt);

                Excel.Range OriginRange = OriginSheet.Range[start + ":" + end];

                ExcelRange.Value = OriginRange.Value;

                labelProgress.Text = j + "번 째 Excel 처리 중...";

                ExcelBook.SaveAs(savePath + "\\공시지가" + j + "." + extension);
                j++;

                ExcelBook.Close();
                ExcelApp.Quit();

                CloseExcel(ExcelRange);
                CloseExcel(ExcelSheet);
                CloseExcel(ExcelBook);
                CloseExcel(ExcelApp);

                backgroundWorker.ReportProgress(j);
            }

            OriginBook.Close();
            OriginApp.Quit();

            CloseExcel(OriginSheet);
            CloseExcel(OriginBook);
            CloseExcel(OriginApp);
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelProgress.Text = "작업 완료";
            MessageBox.Show("Done");
        }

        private int Label(double excelEnd, double cnt)
        {
            double num = excelEnd / cnt;
            labelCount.Text ="총 " + Convert.ToString(Math.Ceiling(num)) + "개";

            return (int)Math.Ceiling(num);
        }

        // Excel 강제 종료
        private void CloseExcel(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }

            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }

            finally
            {
                GC.Collect();
            }
        }
    }
}
