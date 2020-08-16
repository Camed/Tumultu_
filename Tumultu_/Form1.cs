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
using Tumultu_.Tools;
using Tumultu_.Detection;
using Tumultu_.Entropy;
namespace Tumultu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); 
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var fileName = ofd.FileName;
                var ent = new EntropyCounter(fileName, 256);
                var charter = new Charting(ent.GetFileEntropy());
                pictureBox1.Image = charter.GetBitmap();
            }
        }
    }
}
