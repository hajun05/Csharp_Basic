using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Basic
{
    //성적을 국어, 영어, 수학 3가지로 늘이기
    //2차원 배열로 만들어서 데이터를 저장하기
    //2차원 배열을 DataGridView 컨트롤에 표현하기
    //OpenFileDialog를 이용하여 2차원 배열에 있는 데이터를 csv 파일로 저장하기

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        enum Subjects // 열거형으로 과목별 점수 접근(직관성)
        {
            Korean,
            Math,
            English
        }

        private void InputTextButtonClick(object sender, EventArgs e) // 학생수 입력 함수
        {
            int students_num = 0;
            if (int.TryParse(InputText.Text, out students_num))
            {
                InstructionText.Text = "학생 수를 입력하십시오."; // 지시문 초기화
                int[,] students_score = StudentScoreGeneration(students_num);
                OutputStudentsScore(students_num, students_score);
            }
            else
            {
                InstructionText.Text = "잘못된 값을 입력했습니다. 다시 입력하십시오."; // 숫자 이외의 값 입력시 재 입력 지시
            }
        }

        private void OutputStudentsScore(int students_num, int[,] students_score) // 학생들 점수 출력 함수
        {
            StudentsScoreGridView.Rows.Clear(); // 기존의 datagrid 내용 제거

            //for (int i = 0; i < student_num; i++) // 새로운 datagrid 내용 추가
            //{
            //    StudentsScoreGridView.Rows.Add("학생" + i.ToString(),
            //        students_score[i, (int)Subjects.Korean], // 열거형을 이용한 과목 지정
            //        students_score[i, (int)Subjects.Math], 
            //        students_score[i, (int)Subjects.English]);
            //}
            int i = 0;
            while(i < students_num) // for문을 while문으로 변경
            {
                StudentsScoreGridView.Rows.Add("학생" + i.ToString(),
                    students_score[i, (int)Subjects.Korean], // 열거형을 이용한 과목 지정
                    students_score[i, (int)Subjects.Math],
                    students_score[i, (int)Subjects.English]);
                i++;
            }    
        }

        private int[,] StudentScoreGeneration(int students_num) // 2차원 배열로 학생들 점수 저장
        {
            int[,] students_score = new int[students_num, 3];
            Random score = new Random(); 
            
            //for (int i = 0; i < students_num; i++) // 각 과목별 랜덤 점수 저장
            //{
            //    students_score[i, (int)Subjects.Korean] = score.Next(0, 101); // 열거형을 이용한 과목 지정
            //    students_score[i, (int)Subjects.Math] = score.Next(0, 101);
            //    students_score[i, (int)Subjects.English] = score.Next(0, 101);
            //}
            int i = 0;
            while (i < students_num) // for문을 while문으로 변경
            {
                students_score[i, (int)Subjects.Korean] = score.Next(0, 101); // 열거형을 이용한 과목 지정
                students_score[i, (int)Subjects.Math] = score.Next(0, 101);
                students_score[i, (int)Subjects.English] = score.Next(0, 101);
                i++;
            }

            return students_score; // 점수를 저장한 2차열 배열 반환
        }

        private void ExportButtonClick(object sender, EventArgs e) // 학생들 점수 cvs파일로 출력. 김예린 크루의 repo 참고.
        {
            SaveFileDialog saveFileDialog = GetCsvSave();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataGridViewToCSV(saveFileDialog.FileName, StudentsScoreGridView, true);
            }
        }

        private SaveFileDialog GetCsvSave() // csv파일 export 설정
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // 디렉토리 관련 설정
            // export할 디렉토리 위치 저장 
            string export_path = Environment.CurrentDirectory; // 이 코드의 실행 출력 디렉토리(bin.Debug)
            // export할 디렉토리가 실존하는지 검사
            saveFileDialog.CheckPathExists = true;
            // 저장할 위치의 초기 디렉토리 설정
            saveFileDialog.InitialDirectory = export_path; 
            // 대화상자를 닫기 전에 디렉토리를 이전에 선택한 디렉토리로 복원한지의 여부를 나타냄
            saveFileDialog.RestoreDirectory = true;
            // 파일이 이미 존재하면 덮어쓰기를 할지 묻는 대화상자 표시.
            saveFileDialog.OverwritePrompt = true;

            // 확장명 관련 설정
            // 확장자 자동 추가 옵션
            saveFileDialog.AddExtension = true;
            // 확장명을 입려하지 않을 경우, 자동으로 csv로 지정
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "CSV 파일 |*.csv|모든 파일|*.*";
            saveFileDialog.FilterIndex = 1;

            return saveFileDialog;
        }

        private void DataGridViewToCSV(string fileName, DataGridView dgview, bool header)
        {
            string delimiter = ","; //구분자
            FileStream fs = new FileStream(fileName, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter csvExport = new StreamWriter(fs, System.Text.Encoding.UTF8);

            if (dgview.Rows.Count == 0) return;

            // header가 true면 header 정보 출력
            if (header)
            {
                //for (int i = 0; i < dgview.Columns.Count; i++)
                //{
                //    csvExport.Write(dgview.Columns[i].HeaderText);
                //    if (i != dgview.Columns.Count - 1)
                //    {
                //        csvExport.Write(delimiter);
                //    }
                //}
                int i = 0;
                while (i < dgview.Columns.Count) // for문을 while문으로 변경
                {
                    csvExport.Write(dgview.Columns[i].HeaderText);
                    if (i != dgview.Columns.Count - 1)
                    {
                        csvExport.Write(delimiter);
                    }
                    i++;
                }
            }
            csvExport.Write(csvExport.NewLine); //add new line

            //데이터 출력
            foreach (DataGridViewRow row in dgview.Rows)
            {
                if (!row.IsNewRow)
                {
                    //for (int i = 0; i < dgview.Columns.Count; i++)
                    //{
                    //    csvExport.Write(row.Cells[i].Value);
                    //    if (i != dgview.Columns.Count - 1)
                    //    {
                    //        csvExport.Write(delimiter);
                    //    }
                    //}
                    int i = 0;
                    while (i < dgview.Columns.Count) // for문을 while문으로 변경
                    {
                        csvExport.Write(row.Cells[i].Value);
                        if (i != dgview.Columns.Count - 1)
                        {
                            csvExport.Write(delimiter);
                        }
                        i++;
                    }
                    csvExport.Write(csvExport.NewLine); //write new line
                }
            }
            csvExport.Flush();
            csvExport.Close();
            fs.Close();

            InstructionText.Text = "CSV 파일 저장 완료!";
            // 새 노트북 git 설치 설정 확인용
        }
    }
}
