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
        private readonly string dateStamp = DateTime.Now.ToString("yyMMdd");

        public Main()
        {
            InitializeComponent();

            radioButtonAuto.Checked = true;
            radioButtonXLSX.Checked = true;

            textBoxNum.Text = "30000";
            textBoxSave.Enabled = false;
            buttonSave.Enabled = false;

            // Thread 내부에서 Form 요소 변경
            CheckForIllegalCrossThreadCalls = false;
        }

        // 숫자만 입력받기
        private void TextBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        // 저장경로 선택
        private void RadioButtonAuto_CheckedChanged(object sender, EventArgs e)
        {
            // 저장경로 자동 지정
            if (radioButtonAuto.Checked)
            {
                // 공시지가 분할 모드
                if (radioButtonPrice.Checked)
                {
                    savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\공시지가_" + dateStamp;
                    textBoxSave.Enabled = false;
                    buttonSave.Enabled = false;
                }

                // 우편번호 분할 모드
                else if (radioButtonAddress.Checked)
                {
                    savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\우편변호_" + dateStamp;
                    textBoxSave.Enabled = false;
                    buttonSave.Enabled = false;
                }

                // 알수없는 모드
                else
                {
                    MessageBox.Show("모드 오류", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // 저장경로 수동지정
            else
            {
                savePath = textBoxSave.Text;
                textBoxSave.Enabled = true;
                buttonSave.Enabled = true;
            }
        }

        // TextBox에서 직접 경로 받기
        private void TextBoxFilePath_TextChanged(object sender, EventArgs e)
        {
            filePath = textBoxFilePath.Text;
        }

        // TextBox에서 직접 경로 받기
        private void TextBoxSave_TextChanged(object sender, EventArgs e)
        {
            savePath = textBoxSave.Text;
        }

        // Excel 확장자 선택
        private void RadioButtonXLSX_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonXLSX.Checked)
            {
                extension = "xlsx";
            }

            else
            {
                extension = "xls";
            }
        }

        // 공시지가 Excel 선택
        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Excel Files|*.xls; *.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openFileDialog.FileName;
                filePath = openFileDialog.FileName;
            }
        }

        // Input 저장경로 선택
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSave.Text = folderBrowserDialog.SelectedPath;
                savePath = folderBrowserDialog.SelectedPath;
            }
        }

        // 서울시 열린 데이터광장 공시지가 홈페이지 접속
        private void ButtonData_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://data.seoul.go.kr/dataList/datasetView.do?infId=OA-1180&srvType=F&serviceKind=1&currentPageNo=1");
        }

        // 작업 시작
        private void ButtonRun_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            // 해당 파일이 있을 경우 동작
            if (fileInfo.Exists)
            {
                // 공시지가 분할 모드
                if (radioButtonPrice.Checked)
                {
                    backgroundWorkerPrice.RunWorkerAsync();
                }

                // 우편번호 분할 모드
                else if (radioButtonAddress.Checked)
                {
                    // TODO..
                }

                // 알수없는 모드
                else
                {
                    MessageBox.Show("모드 오류", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // 없을 경우 오류 출력
            else
            {
                MessageBox.Show("해당 파일을 사용할 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 공시지가 작업 프로세스
        private void BackgroundWorkerPrice_DoWork(object sender, DoWorkEventArgs e)
        {
            labelProgress.Text = "작업 준비중...";

            DirectoryInfo directoryInfo = new DirectoryInfo(savePath);

            // 경로가 없을 경우 생성
            if (!directoryInfo.Exists)
                directoryInfo.Create();

            // 공시지가 Excel 속성
            Excel.Application OriginApp = new Excel.Application
            {
                Visible = true,
                DisplayAlerts = false,
                Interactive = false
            };

            Excel.Workbook OriginBook = OriginApp.Workbooks.Open(filePath);
            Excel.Worksheet OriginSheet = OriginBook.ActiveSheet;

            // 계산용 변수 지정
            int excelEnd = OriginSheet.UsedRange.Rows.Count;
            int cnt = Convert.ToInt32(textBoxNum.Text);
            int size = Label(excelEnd, cnt);

            // Progress Bar 최대값 지정
            progressBar.Maximum = size;

            // Excel 사용에 문제가 생길 경우
            if (OriginApp == null)
            {
                MessageBox.Show("Excel을 정상적으로 사용할 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int j = 1;

            // cnt 수 만큼의 cell 복사 & 붙여넣기
            for (int i = 2; i <= excelEnd; i += cnt)
            {
                // Progress 반영
                progressBar.Value = j;

                // 나눠진 Excel 속성
                Excel.Application ExcelApp = new Excel.Application
                {
                    Visible = false,
                    DisplayAlerts = false,
                    Interactive = false
                };

                Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet ExcelSheet = ExcelBook.ActiveSheet;

                /*=======================================================
                 * cnt = 30000일 경우
                 * 
                 * 각 Row의 첫 번째 Column은 해당 데이터의 Label이 들어감
                 * 
                 * 따라서, 30000만개의 데이터
                 * 2 ~ 30001의 범위
                 =======================================================*/

                Excel.Range ExcelRange = ExcelSheet.Range["A2:B" + (cnt + 1)];

                // 주소와 공시지가 Row 자동지정
                ExcelSheet.Cells[1, 1] = "ADDRESS";
                ExcelSheet.Cells[1, 2] = "JIGA";

                // 작업 횟수에 따라 cnt만큼 Range 이동
                string start = "A" + Convert.ToString(i);
                string end = "B" + Convert.ToString(i + cnt);

                // ExcelRange와 동일한 원리. 단, Origin의 Range는 계속 이동
                Excel.Range OriginRange = OriginSheet.Range[start + ":" + end];

                // 해당 Origin의 값 붙여넣기
                ExcelRange.Value = OriginRange.Value;

                // 현재 작업 표시
                labelProgress.Text = j + "번 째 Excel 처리 중...";

                // Cell 붙여넣은 후 Excel 저장
                ExcelBook.SaveAs(savePath + "\\공시지가" + j + "." + extension);
                j++;

                // Excel 인스턴스 제거
                ExcelBook.Close();
                ExcelApp.Quit();

                CloseExcel(ExcelRange);
                CloseExcel(ExcelSheet);
                CloseExcel(ExcelBook);
                CloseExcel(ExcelApp);
            }

            // Excel 인스턴스 제거
            OriginBook.Close();
            OriginApp.Quit();

            CloseExcel(OriginSheet);
            CloseExcel(OriginBook);
            CloseExcel(OriginApp);
        }

        // 작업 종료
        private void BackgroundWorkerPrice_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelProgress.Text = "작업 완료";
            progressBar.Value = 0;
            MessageBox.Show("Done");
        }

        // 작업 총량 Label 표시
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

/*
 * Icons made by https://www.freepik.com/?__hstc=57440181.013cd376e8f15b1b1c89fddd955d690a.1561172241104.1561172241104.1561172241104.1&__hssc=57440181.2.1561172241105&__hsfp=421475909
 * from https://www.flaticon.com/
 * 
 * licensed by http://creativecommons.org/licenses/by/3.0/
 * "Creative Commons BY 3.0
 * CC 3.0 BY
 */
