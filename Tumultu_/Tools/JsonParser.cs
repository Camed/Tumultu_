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
            JToken scan_id = json["scan_id"];
            JToken sha1 = json["sha1"];
            JToken resource = json["resource"];
            JToken responsecode = json["response_code"];
            JToken scandate = json["scan_date"];
            JToken permalink = json["permalink"];
            JToken verbosemsg = json["verbose_msg"];
            JToken total = json["total"];
            JToken positives = json["positives"];
            JToken sha256 = json["sha256"];
            JToken md5 = json["md5"];

            int respCode = int.Parse(responsecode.ToString());
            if(respCode == 1)
            {
                //...
            }
            else
            {
                //...
            }
            //System.Windows.Forms.Clipboard.SetText(json.ToString());
            return "";
        }
    }
}
