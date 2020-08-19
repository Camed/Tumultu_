using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Schema;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Tumultu_.Tools
{
    public class VirusTotal
    {
        /// <summary>
        /// Your VirusTotal APIKEY
        /// </summary>
        public string ApiKey { get; set; }

        private WebRequest _request;
        private HttpWebResponse _response;


        /// <param name="apiKey">Your VT apikey</param>
        public VirusTotal(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Get file info from VT by hash
        /// </summary>
        /// <param name="hash">MD5, SHA1, SHA256 hash of the file</param>
        /// <returns>JSON stored in string</returns>
        public string GetFileReport(string hash)
        {
            try
            {
                _request = WebRequest.Create($"https://www.virustotal.com/vtapi/v2/file/report?apikey={ApiKey}&resource={hash}");
                _response = (HttpWebResponse)_request.GetResponse();

                Stream ds = _response.GetResponseStream();
                StreamReader sr = new StreamReader(ds);
                string response = sr.ReadToEnd();

                ds.Close();
                sr.Close();
                _response.Close();
                return response;
            }
            catch
            {
                MessageBox.Show("Probably incorrect API key!");
                return null;
            }
        }

        /// <summary>
        /// Get comments from VirusTotal users about the file (by hash)
        /// </summary>
        /// <param name="hash">MD5, SHA1, SHA256 hash of the file</param>
        /// <returns>JSON stored in string</returns>
        public string GetFileComments(string hash)
        {
            try
            {
                _request = WebRequest.Create($"https://www.virustotal.com/vtapi/v2/comments/get?apikey={ApiKey}&resource={hash}");
                _response = (HttpWebResponse)_request.GetResponse();

                var sr = new StreamReader(_response.GetResponseStream());
                string response = sr.ReadToEnd();
                sr.Close();
                _response.Close();
                return response;
            }
            catch
            {
                MessageBox.Show("Probably incorrect API key!");
                return null;
            }

        }
    }
}
