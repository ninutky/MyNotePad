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

namespace MyNotePad
{
    public partial class 마이메모장 : Form
    {
        public 마이메모장()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            openFileDialog1.ShowDialog(this);
            textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            saveFileDialog1.ShowDialog(this);
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }
    }
}
