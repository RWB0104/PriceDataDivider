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

        // 공시지가 모드
        private void RadioButtonPrice_CheckedChanged(object sender, EventArgs e)
        {
            buttonData.BackgroundImage = Properties.Resources.data_logo;

            // 저장경로 자동 지정일 경우
            if (radioButtonAuto.Checked)
            {
                savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\공시지가_" + dateStamp;
                textBoxSave.Enabled = false;
                buttonSave.Enabled = false;
            }

            // 저장경로 직접 입력일 경우
            else if (radioButtonInput.Checked)
            {
                savePath = textBoxSave.Text;
                textBoxSave.Enabled = true;
                buttonSave.Enabled = true;
            }

            // 알수없는 경로 지정방법
            else
            {
                MessageBox.Show("경로 지정방법 오류", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 주소 모드
        private void RadioButtonAddress_CheckedChanged(object sender, EventArgs e)
        {
            buttonData.BackgroundImage = Properties.Resources.post_logo;

            // 저장경로 자동 지정일 경우
            if (radioButtonAuto.Checked)
            {
                savePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\우편변호_" + dateStamp;
                textBoxSave.Enabled = false;
                buttonSave.Enabled = false;
            }

            // 저장경로 직접 입력일 경우
            else if (radioButtonInput.Checked)
            {
                savePath = textBoxSave.Text;
                textBoxSave.Enabled = true;
                buttonSave.Enabled = true;
            }

            // 알수없는 경로 지정방법
            else
            {
                MessageBox.Show("모드 오류", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // 주소 분할 모드
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

        // 해당 데이터를 보유한 홈페이지 접속
        private void ButtonData_Click(object sender, EventArgs e)
        {
            // 공시지가 분할 모드
            if (radioButtonPrice.Checked)
            {
                System.Diagnostics.Process.Start("https://data.seoul.go.kr/dataList/datasetView.do?infId=OA-1180&srvType=F&serviceKind=1&currentPageNo=1");
            }

            // 주소 분할 모드
            else if (radioButtonAddress.Checked)
            {
                System.Diagnostics.Process.Start("https://www.epost.go.kr/search/zipcode/cmzcd002k01.jsp");
            }

            // 알수없는 모드
            else
            {
                MessageBox.Show("모드 오류", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                // 주소 분할 모드
                else if (radioButtonAddress.Checked)
                {
                    backgroundWorkerAddress.RunWorkerAsync();
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
            {
                directoryInfo.Create();
            }

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
                e.Cancel = true;
            }

            int j = 1;

            // cnt 수 만큼의 cell 복사 & 붙여넣기
            for (int i = 2; i <= excelEnd; i += cnt)
            {
                // 현재 작업 표시
                labelProgress.Text = j + "번 째 Excel 처리 중...";

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
                 * 따라서, 30000만개의 데이터는
                 * 2 ~ 30001의 범위를 가짐
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

        // 주소 작업 프로세스
        private void BackgroundWorkerAddress_DoWork(object sender, DoWorkEventArgs e)
        {
            labelProgress.Text = "작업 준비중...";

            DirectoryInfo directoryInfo = new DirectoryInfo(savePath);

            // 경로가 없을 경우 생성
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            // 주소 Excel 속성
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
                e.Cancel = true;
            }

            int j = 1;

            // cnt 수 만큼의 cell 복사 & 붙여넣기
            for (int i = 2; i <= excelEnd; i += cnt)
            {
                // 현재 작업 표시
                labelProgress.Text = j + "번 째 Excel 처리 중...";

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
                 * 따라서, 30000만개의 데이터는
                 * 2 ~ 30001의 범위를 가짐
                 =======================================================*/

                Excel.Range ExcelRange = ExcelSheet.Range["A2:Z" + (cnt + 1)];

                // 주소와 공시지가 Row 자동지정
                for (int n = 1; n <= 26; n++)
                {
                    Excel.Range cellRange = OriginSheet.Cells[1, n];
                    ExcelSheet.Cells[1, n] = AddressColumn(cellRange.Value);
                }

                // 작업 횟수에 따라 cnt만큼 Range 이동
                string start = "A" + Convert.ToString(i);
                string end = "Z" + Convert.ToString(i + cnt);

                // ExcelRange와 동일한 원리. 단, Origin의 Range는 계속 이동
                Excel.Range OriginRange = OriginSheet.Range[start + ":" + end];

                // 해당 Origin의 값 붙여넣기
                ExcelRange.Value = OriginRange.Value;

                // Column 처리
                for (int n = 1; n <= 26; n++)
                {
                    Excel.Range cellRange = OriginSheet.Cells[1, n];
                    Excel.Range resultRange = ExcelSheet.Columns[n];

                    // Column이 '제거'일 경우
                    if (AddressColumn(cellRange.Value) == "제거")
                    {
                        // 해당 Column 제거
                        ExcelSheet.Columns[n].Delete();
                    }

                    // Column이 'ZIP_CL'일 경우
                    if (AddressColumn(cellRange.Value) == "ZIP_CL")
                    {
                        // 해당 Column 텍스트 서식 지정 (숫자로 하면 앞의 0이 사라짐)
                        resultRange.NumberFormat = "@";
                    }

                    // Column이 지정된 이름일 경우
                    if (AddressColumn(cellRange.Value) == "DORO_CD" || AddressColumn(cellRange.Value) == "BD_MAN_NO" || AddressColumn(cellRange.Value) == "BJ_CD")
                    {
                        // 해당 Column 숫자 서식 지정 (미지정 시 지수 형태로 출력)
                        resultRange.NumberFormat = "0";
                    }
                }

                // Cell 붙여넣은 후 Excel 저장
                ExcelBook.SaveAs(savePath + "\\주소" + j + "." + extension);
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

        // 공시지가 작업 종료
        private void BackgroundWorkerPrice_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelProgress.Text = "공시지가 작업 완료";
            progressBar.Value = 0;
            MessageBox.Show("공시지가 분할 완료", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 주소 작업 종료
        private void BackgroundWorkerAddress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelProgress.Text = "주소 작업 완료";
            progressBar.Value = 0;
            MessageBox.Show("주소 분할 완료", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private string AddressColumn(string cell)
        {
            // 해당 Column에 매칭되는 DB의 Column으로 치환
            switch (cell)
            {
                case "우편번호":
                    return "ZIP_CL";

                case "시도":
                    return "SI_NM";

                case "시도영문":
                    return "SI_NM_ENG";

                case "시군구":
                    return "SGG_NM";

                case "시군구영문":
                    return "SGG_NM_ENG";

                case "읍면":
                    return "UM_NM";

                case "읍면영문":
                    return "UM_NM_ENG";

                case "도로명코드":
                    return "DORO_CD";

                case "도로명":
                    return "DORO_NM";

                case "도로명영문":
                    return "DORO_ENG";

                case "지하여부":
                    return "LAYER_CD";

                case "건물번호본번":
                    return "BD_BON";

                case "건물번호부번":
                    return "BD_BU";

                case "건물관리번호":
                    return "BD_MAN_NO";

                case "다량배달처명":
                    return "MULTI_SEND";

                case "시군구용건물명":
                    return "BD_NM";

                case "법정동코드":
                    return "BJ_CD";

                case "법정동명":
                    return "EMD_NM";

                case "리명":
                    return "RI_NM";

                case "행정동명":
                    return "HJ_NM";

                case "산여부":
                    return "SPC_CD";

                case "지번본번":
                    return "BON";

                case "읍면동일련번호":
                    return "UMD_SN";

                case "지번부번":
                    return "BU";

                case "우편번호일련번호":
                    return "ORDER_CN";

                // 나머지 필요없는 Column 표시
                default:
                    return "제거";
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
