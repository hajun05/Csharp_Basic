using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp_Basic
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            try
            {
                string content = File.ReadAllText(@"C:\Users\Hajun\source\repos\Csharp_Basic\input.txt");

                FileInput(content, out int content_num, out List<string> final_output);
            }
            catch(DirectoryNotFoundException e)
            {
                MessageBox.Show("존재하지 않는 파일 경로입니다.");
            }
        }

        // 파일 내용중 숫자로 변환 가능한 내용만 출력, 변환 불가능한 부분은 _ 기호로 출력
        public void FileInput(string file_content, out int content_num, out List<string> final_output)
        {
            string[] content = file_content.Split('\n'); 
            final_output = new List<string>();
            content_num = 0;
            int i = 0;
            try
            {
                for (i = 0; i < content.Length; i++)
                {
                    // 파일 내용이 숫자 변환 가능한지 확인, 불가할시 예외처리
                    content_num = int.Parse(content[i]);
                    final_output.Add(content[i]);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("NULL 위치를 참조했습니다.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("int형의 크기로 처리할 수 없는 수입니다.");
            }
            catch (FormatException)
            {
                MessageBox.Show("숫자로 변환할 수 없는 파일 내용이 존재합니다.");
                for (int j = i; j < content.Length; j++)
                {
                    int convert;
                    if (int.TryParse(content[j], out convert)) 
                    {
                        final_output.Add(content[j]);
                    }
                    else
                    {
                        List<char> temp_char = new List<char>();
                        foreach (char c in content[j])
                        {
                            if ('0' <= c && c <= '9')
                            {
                                temp_char.Add(c);
                            }
                            // 메모장도 줄바꿈 = "\r\n"
                            else if (c == '\r')
                            {
                                break;
                            }
                            else
                            {
                                temp_char.Add('_');
                            }
                        }

                        if (temp_char.Count > 0)
                        {
                            final_output.Add(String.Join("", temp_char));
                        }
                    }
                }
            }
            finally
            {
                for (int n = 0; n < final_output.Count; n++)
                {
                    textBox1.Text += final_output[n] + "\r\n";
                }
            }
        }
    }
}
