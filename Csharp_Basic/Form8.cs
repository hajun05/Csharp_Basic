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
using System.Xml;

namespace Csharp_Basic
{
    public partial class Form8 : Form
    {
        // 파일에 저장된 id_pw, id_phone 데이터를 딕셔너리 저장
        Dictionary<string, string> id_pw = new Dictionary<string, string>();
        Dictionary<string, string> id_phone = new Dictionary<string, string>();

        public Form8()
        {
            InitializeComponent();
        }

        // 파일 탐색, 파일의 정보 읽기
        private void button1_Click(object sender, EventArgs e)
        {
            // OpenfileDialog 활용. 참고 : https://hvyair.tistory.com/44
            try
            {
                //인스턴스 생성
                using (OpenFileDialog ofd = new OpenFileDialog())
                {

                    // 사용할 필터(확장자) 설정
                    List<string> filterList = new List<string>{
                    "Bitmap(*.bmp, *dib)|*.bmp;*.dib;",
                    "|JPEG(*.jpg, *.jpeg, *.jpe, *.jfif)|*.jpg; *.jpeg; *.jpe; *.jfif;",
                    "|TIFF(*.tif, *.tiff)|*.tif; *.tiff;", "|GIF(*.gif)|*.gif",
                    "|PNG(*.png)|*.png;",
                    "|TXT(*.txt)|*.txt;"
                };

                    // 필터(확장자 적용)
                    foreach (string filter in filterList)
                    { ofd.Filter += filter; }

                    // 또는 아래와 같이 한꺼번에 Supported Image File로 표시할 수 있다.
                    //ofd.Filter = "Supported Image File|*jpg;*.jpeg;*.bmp;*.png;*.dib;*.gif;*.tif;";

                    ofd.AddExtension = false;                    // 확장자 자동 추가
                    ofd.CheckFileExists = true;                  // 파일 존재하지 않을 경우 메시지 표시 여부
                    ofd.CheckPathExists = true;                  // 경로 존재하지 않을 경우 메시지 표시 여부    
                    ofd.Multiselect = false;                     // 복수 선택

                    ofd.ShowHelp = true;                         // Help 버튼 표시 여부
                    ofd.ShowReadOnly = false;                    // 읽기 전용 체크박스 표시 여부
                    ofd.ReadOnlyChecked = false;                 // 읽기 전용항목 체크 여부
                    ofd.SupportMultiDottedExtensions = true;     // 여러개의 확장자를 표시하는지 여부(저장시 또한)
                    ofd.Title = "Select an image...";            // 타이틀 표시
                    ofd.ValidateNames = true;                    // 파일명의 유효성 검증

                    //초기 디렉터리 -> 바탕화면으로 설정
                    ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                    if (ofd.ShowDialog() == DialogResult.OK) // 다이얼로그 표시
                    {
                        // OpenFileDialog로 접근한 파일을 StreamReader로 열기
                        using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
                        {
                            // 파일 내용
                            //john,12313,01012345678
                            //raymond,321321,01045671234
                            //codingon,111111
                            //posco,2580,026159487

                            while (true)
                            {
                                string line = sr.ReadLine();
                                if (line != null)
                                {
                                    string[] temp_str = line.Split(',');
                                    id_pw.Add(temp_str[0], temp_str[1]);
                                    if (temp_str.Length > 2)
                                    {
                                        id_phone.Add(temp_str[0], temp_str[2]);
                                    }
                                    else
                                    {
                                        id_phone.Add(temp_str[0], null);
                                    }
                                }
                                else
                                    break;
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString(), "존재하지 않거나 다른 위치에서 열려있는 파일입니다.");
            }
            catch
            {
                MessageBox.Show("유효하지 않은 데이터를 지닌 파일입니다.");
            }
        }

        // 로그인 실행
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string input_ID = InputID.Text;
                string input_PW = InputPW.Text;
                if (id_pw.ContainsKey(input_ID) && id_phone.ContainsKey(input_ID))
                {
                    if (id_pw[input_ID] == input_PW)
                    {
                        string output;
                        if (id_phone[input_ID] != null)
                        {
                            output = string.Format($"ID : {input_ID}\r\n전화변호 : {id_phone[input_ID]}");
                        }
                        else
                        {
                            output = string.Format($"ID : {input_ID}\r\n전화변호 : 없음");
                        }
                        MessageBox.Show($"로그인 성공!\r\n{output}");
                    }
                    else
                    {
                        MessageBox.Show($"로그인 실패\r\n비밀번호 입력이 잘못되었습니다.");
                    }
                }
                else
                {
                    MessageBox.Show($"로그인 실패\r\nID 입력이 잘못되었습니다.");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "로그인 오류 발생.");
            }
        }
    }
}
