using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tumultu_.Tools
{
    class JsonParser
    {
        /*class ScanResult
        {
            public bool detected { get; set; }
            public string version { get; set; }
            public 
        }*/

        public string ParseComments(JObject json)
        {
            StringBuilder sb = new StringBuilder();


            return "";
        }

        public string ParseResults(JObject json)
        {
            StringBuilder sb = new StringBuilder();

            JToken scans = json["scans"]; /// maybe sth in the future
            JToken scan_id = json["scan_id"];//
            JToken sha1 = json["sha1"];//
            JToken responsecode = json["response_code"];//
            JToken scandate = json["scan_date"];//
            JToken permalink = json["permalink"];//
            JToken verbosemsg = json["verbose_msg"];
            JToken total = json["total"];
            JToken positives = json["positives"];
            JToken sha256 = json["sha256"];///
            JToken md5 = json["md5"];///


            int respCode = int.Parse(responsecode.ToString());
            if(respCode == 0)
            {
                MessageBox.Show("File not found in VirusTotal database. Please visit https://virustotal.com to scan the file.", "Tumultu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sb.AppendLine("Tumultu_ file log! by camed\n With love towards VirusTotal <3");
                sb.AppendLine($"\n{verbosemsg.ToString()}");
            }
            else
            {
                sb.AppendLine("Tumultu_ file log! by camed\n With love towards VirusTotal <3");
                sb.AppendLine($"\n{verbosemsg.ToString()}");
                sb.AppendLine($"Date: {DateTime.Now}");
                sb.AppendLine($"Last scan date: {scandate.ToString()}");
                sb.AppendLine($"Link: {permalink.ToString()}");
                sb.AppendLine($"Scan ID: {scan_id.ToString()}\n\n");
                sb.AppendLine($"File MD5: {md5.ToString()}");
                sb.AppendLine($"File SHA1: {sha1.ToString()}");
                sb.AppendLine($"File SHA256: {sha256.ToString()}");
                string[] verdicts = { "Probably safe", "Can be malicious" };
                sb.AppendLine($"Verdict (positives/total engines): {positives.ToString()}/{total.ToString()}. {(int.Parse(positives.ToString()) == 0 ? verdicts[0] : verdicts[1])}");
            }
            return sb.ToString();
        }
    }
}
