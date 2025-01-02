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
        string content = File.ReadAllText(@"C:\Users\Hajun\source\repos\Csharp_Basic\input.txt");
        public Form7()
        {
            InitializeComponent();

            FileInput(content, out int[] file_input);
        }

        public void FileInput(string file_content, out int[] file_input)
        {
            string[] content = file_content.Split('\n');
            file_input = new int[content.Length];
            try
            {
                for (int i = 0; i < content.Length; i++)
                {
                    file_input[i] = int.Parse(content[i]);
                }
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("존재하지 않는 파일입니다.");
            }
            catch (OverflowException e)
            {
                MessageBox.Show("int형의 크기로 처리할 수 없는 수입니다.");
            }
            catch (FormatException e)
            {
                MessageBox.Show("숫자로 변환할 수 없는 파일 내용이 존재합니다.");
            }
            finally
            {
                for (int i = 0; i < file_input.Length; i++)
                {
                    MessageBox.Show(file_input[i].ToString());
                }
            }
        }
    }
}
