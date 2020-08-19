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
        string path;

        /// <param name="path">Path to a file you want to analyze</param>
        public DetectionInfo(string path)
        {
            this.path = path;
        }
        /// <summary>
        /// Detects file type based on first bytes
        /// </summary>
        /// <returns>Returns empty string (if no match found) or plausible file type</returns>
        public string Detect()
        {
            byte[] file = File.ReadAllBytes(path);
            StringBuilder sb = new StringBuilder();
            foreach(var x in DetectionSignatures.Detectors)
                if (file.Take(x.Key.Length).SequenceEqual(x.Key))
                    sb.AppendLine($"{x.Value}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Getting MD5 Hash of a file
        /// </summary>
        public string getMD5()
        {
            using(var md5 = MD5.Create())
            {
                using(var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToUpperInvariant();
                }
            }
        }
        /// <summary>
        /// Getting SHA1 Hash of a file
        /// </summary>
        public string getSHA1()
        {
            using (var sha1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(sha1.ComputeHash(stream)).Replace("-", "").ToUpperInvariant();
                }
            }
        }

        /// <summary>
        /// Getting SHA256 Hash of a file
        /// </summary>
        public string getSHA256()
        {
            using (var sha256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(sha256.ComputeHash(stream)).Replace("-", "").ToUpperInvariant();
                }
            }
        }

        /// <summary>
        /// Getting SHA512 Hash of a file
        /// </summary>
        public string getSHA512()
        {
            using (var sha512 = SHA512.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(sha512.ComputeHash(stream)).Replace("-", "").ToUpperInvariant();
                }
            }
        }
    }
}
