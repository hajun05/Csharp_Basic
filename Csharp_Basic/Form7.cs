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

                FileInput(content, out List<int> file_input);
            }
            catch(DirectoryNotFoundException e)
            {
                MessageBox.Show("존재하지 않는 파일 경로입니다.");
            }
        }

        public void FileInput(string file_content, out List<int> file_input)
        {
            string[] content = file_content.Split('\n'); 
            file_input = new List<int>();
            int i = 0;
            try
            {
                for (i = 0; i < content.Length; i++)
                {
                    file_input.Add(int.Parse(content[i]));
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
                        file_input.Add(convert);
                    }
                    else
                    {
                        string temp = "";
                        foreach (char c in content[j])
                        {
                            if ('0' <= c && c <= '9')
                            {
                                temp += c;
                            }
                            else if (c == '\n')
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (temp != "")
                        {
                            int.TryParse(temp, out convert);
                            file_input.Add(convert);
                        }
                    }
                }
            }
            finally
            {
                for (int n = 0; n < file_input.Count; n++)
                {
                    textBox1.Text += file_input[n].ToString() + "\r\n";
                }
            }
        }
    }
}
