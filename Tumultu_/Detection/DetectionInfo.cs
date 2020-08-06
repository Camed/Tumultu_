using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tumultu_.Detection
{
    
    public class DetectionInfo
    {

        public string Detect(byte[] file)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var x in DetectionSignatures.Detectors)
                if (file.Take(x.Key.Length).SequenceEqual(x.Key))  
                    sb.Append($"possible: {x.Key}\n");
            return sb.ToString();
        }

    }
}
