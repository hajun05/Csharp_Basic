using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Basic
{
    // 1. 멀티스레드를 생성하는 3가지 방법(backgroundworker, Thread, async) 각각 구현
    // 2. 각 방법들 중 원하는 방법을 골라 파일 검색 실행. 각 방법들에 걸린 시간도 체크
    // 3. OpenFileDialog로 파일 경로 선택, 해당 경로의 특정 확장자의 모든 파일을 조회
    // 4. 조회한 파일 목록을 gridview로 출력
    // 5. 예외처리도 구현
    public partial class Form_1 : Form
    {
        public Form_1()
        {
            InitializeComponent();
        }
    }
}
