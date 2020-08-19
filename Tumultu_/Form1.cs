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
using System.Security.Cryptography;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Tumultu_
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// some constants and fileds 
        /// </summary>
        private const long MINIMUM_FILE_SIZE = 256;
        private const long MAXIMUM_FILE_SIZE = 134217728;
        private string lastFilePath = "";
        private string vtResult = "none";
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// generally manage input and do all the stuff
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            lastFilePath = "";
            vtResult = "none";
            OpenFileDialog ofd = new OpenFileDialog(); 
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var fi = new FileInfo(ofd.FileName);
                if(fi.Length < MINIMUM_FILE_SIZE)
                {
                    MessageBox.Show($"File is too small! Minimum size of a file is {MINIMUM_FILE_SIZE} bytes!");
                    return;
                }
                else if(fi.Length > MAXIMUM_FILE_SIZE)
                {
                    MessageBox.Show($"File is too big! Maximum size of a file is {MAXIMUM_FILE_SIZE} bytes!");
                    return;
                }
                lastFilePath = ofd.FileName;
                saveButton.Enabled = true;
                vtButton.Enabled = true;
                List<double> entropy;
                var fileName = ofd.FileName;
                bool res = int.TryParse(textBox1.Text, out int temp);
                if (!res) MessageBox.Show("Incorrect number or no sample number included, using default value of 256.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int samples = res ? temp : 256;
                if (samples < 64) samples = 64;
                if (samples > fi.Length) samples = 256;
                var ent = new EntropyCounter(fileName, samples);
                entropy = ent.GetFileEntropy();
                var charter = new Charting(entropy);
                pictureBox1.Image = charter.GetBitmap();


                DetectionInfo detectionInfo = new DetectionInfo(ofd.FileName);

                md5label.Text = detectionInfo.getMD5();
                sha1label.Text = detectionInfo.getSHA1();
                sha256label.Text = detectionInfo.getSHA256();
                sha512label.Text = detectionInfo.getSHA512();

                locationLabel.Text = ofd.FileName;

                double sum = 0;
                entropy.ForEach(x => sum += x);
                avgEntLabel.Text = (sum / samples).ToString();

                fileSizeLabel.Text = new FileInfo(ofd.FileName).Length.ToString();

                fileTypesLabel.Text = detectionInfo.Detect();

            }
            else
            {
                MessageBox.Show("No file chosen!");
                vtButton.Enabled = false;
                saveButton.Enabled = false;
            }
        }

        /// <summary>
        /// Saving gathered data to files
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                var path = fbd.SelectedPath;
                var imagePath = path +
                                $"/{Path.GetFileNameWithoutExtension(lastFilePath)}_chart.png";
                if (File.Exists(imagePath)) File.Delete(imagePath);
                pictureBox1.Image.Save(imagePath, ImageFormat.Png);

                var vtResultPath = path +
                                   $"/{Path.GetFileNameWithoutExtension(lastFilePath)}_vtreport.txt";
                if (File.Exists(vtResultPath)) File.Delete(vtResultPath);
                File.WriteAllText(vtResultPath, vtResult);

                var fileInfoPath = path +
                                   $"/{Path.GetFileNameWithoutExtension(lastFilePath)}_info.txt";
                if (File.Exists(fileInfoPath)) File.Delete(fileInfoPath);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Hashes:");
                sb.AppendLine($"MD5: {md5label.Text}");
                sb.AppendLine($"SHA1: {sha1label.Text}");
                sb.AppendLine($"SHA256: {sha256label.Text}");
                sb.AppendLine($"SHA512: {sha512label.Text}");
                sb.AppendLine("\n\n");
                sb.AppendLine($"Location: {locationLabel.Text}");
                sb.AppendLine($"Average entropy: {avgEntLabel.Text}");
                sb.AppendLine($"File size in bytes: {fileSizeLabel.Text}");
                sb.AppendLine($"Possible type of a file: {fileTypesLabel.Text}");
                File.WriteAllText(fileInfoPath, sb.ToString());
                MessageBox.Show("Everything was saved successfully!");
            }
        }
        private void vtButton_Click(object sender, EventArgs e)
        {
            string key = vtKeyTextBox.Text;
            if (string.IsNullOrEmpty(key) || key.Length != 64)
            {
                MessageBox.Show("Please insert correct Virus Total API key");
                return;
            } 
            DetectionInfo dt = new DetectionInfo(lastFilePath);
            VirusTotal vt = new VirusTotal(key);
            JsonParser jp = new JsonParser();
            string report = vt.GetFileReport(dt.getMD5());
            vtResult = jp.ParseResults(JObject.Parse(report));

            var name = Path.GetTempFileName();
            File.WriteAllText(name + ".txt", vtResult);
            System.Diagnostics.Process.Start(name + ".txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/camed");
        }

        private void locationLabel_Click(object sender, EventArgs e)
        {
            MouseEventArgs ex = (MouseEventArgs)e;
            if(ex.Button == MouseButtons.Right)
            {
                Clipboard.SetText(locationLabel.Text);
            }
        }

        private void md5label_Click(object sender, EventArgs e)
        {
            MouseEventArgs ex = (MouseEventArgs)e;
            if (ex.Button == MouseButtons.Right)
            {
                Clipboard.SetText(md5label.Text);
            }
        }

        private void sha1label_Click(object sender, EventArgs e)
        {
            MouseEventArgs ex = (MouseEventArgs)e;
            if (ex.Button == MouseButtons.Right)
            {
                Clipboard.SetText(sha1label.Text);
            }
        }

        private void sha256label_Click(object sender, EventArgs e)
        {
            MouseEventArgs ex = (MouseEventArgs)e;
            if (ex.Button == MouseButtons.Right)
            {
                Clipboard.SetText(sha256label.Text);
            }
        }

        private void sha512label_Click(object sender, EventArgs e)
        {
            MouseEventArgs ex = (MouseEventArgs)e;
            if (ex.Button == MouseButtons.Right)
            {
                Clipboard.SetText(sha512label.Text);
            }
        }

        private void avgEntLabel_Click(object sender, EventArgs e)
        {
            MouseEventArgs ex = (MouseEventArgs)e;
            if (ex.Button == MouseButtons.Right)
            {
                Clipboard.SetText(avgEntLabel.Text);
            }
        }

        private void fileSizeLabel_Click(object sender, EventArgs e)
        {
            MouseEventArgs ex = (MouseEventArgs)e;
            if (ex.Button == MouseButtons.Right)
            {
                Clipboard.SetText(fileSizeLabel.Text);
            }
        }

        private void fileTypesLabel_Click(object sender, EventArgs e)
        {
            MouseEventArgs ex = (MouseEventArgs)e;
            if (ex.Button == MouseButtons.Right)
            {
                Clipboard.SetText(fileTypesLabel.Text);
            }
        }


    }
}
 