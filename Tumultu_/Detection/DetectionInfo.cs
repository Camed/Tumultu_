using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tumultu_.Detection
{
    public class DetectionInfo
    {
        private FileStream fs;
        public DetectionInfo(FileStream fs)
        {
            this.fs = fs;
        }
        public DetectionInfo(string path)
        {
            fs = new FileStream(path, FileMode.Open);
        }

        public string Detect(byte[] file)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var x in DetectionSignatures.Detectors)
                if (file.Take(x.Key.Length).SequenceEqual(x.Key))
                    sb.Append($"possible: {x.Key}\n");
            return sb.ToString();
        }

        public string getMD5()
        {
            return Encoding.UTF8.GetString(MD5.Create().ComputeHash(File.ReadAllBytes(fs.Name))).ToUpper();
        }
        public string getSHA1()
        {
            return Encoding.UTF8.GetString(SHA1.Create().ComputeHash(File.ReadAllBytes(fs.Name))).ToUpper();
        }
        public string getSHA256()
        {
            return Encoding.UTF8.GetString(SHA256.Create().ComputeHash(File.ReadAllBytes(fs.Name))).ToUpper();
        }
        public string getSHA512()
        {
            return Encoding.UTF8.GetString(SHA512.Create().ComputeHash(File.ReadAllBytes(fs.Name))).ToUpper();
        }


        
    }
}
