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
using Newtonsoft.Json.Linq;
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
                VirusTotal vt = new VirusTotal("14fdd3ef60857243997d93af03b0045dc45f415778ffd81e8ebe9ba265ce0c46");
                DetectionInfo detectionInfo = new DetectionInfo(ofd.FileName);
                JsonParser jp = new JsonParser();
                string report = vt.GetFileReport(detectionInfo.getMD5());
                jp.ParseResults(JObject.Parse(report));
            }
        }
    }
}
