using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumultu_.Detection
{
    /// <summary>
    /// Bytes sequences to detect file types will be stored there
    /// </summary>
    public static class DetectionSignatures
    {
        public static Dictionary<byte[], string> Detectors = new Dictionary<byte[], string>();


        /// <summary>
        /// Adding signatures (ik, hardcoded), in love with english wiki
        /// </summary>
        static DetectionSignatures()
        {
            Detectors.Add(new byte[] { 0x23, 0x21 }, "script/shebang");
            Detectors.Add(new byte[] { 0xa1, 0xb2, 0xc3, 0xd4 }, "pcap/libpcap");
            Detectors.Add(new byte[] { 0xd4, 0xc3, 0xb2, 0xa1 }, "pcap/libpcap");
            Detectors.Add(new byte[] { 0x0a, 0x0d, 0x0d, 0x0a }, "pcapng/dump_file");
            Detectors.Add(new byte[] { 0xed, 0xab, 0xee, 0xdb }, "rpm/redhat_package");
            Detectors.Add(new byte[] { 0x53, 0x51, 0x4c, 0x69,
                                       0x74, 0x65, 0x20, 0x66,
                                       0x6f, 0x72, 0x6d, 0x61,
                                       0x74, 0x20, 0x33, 0x00}, "sqlite/database");
            Detectors.Add(new byte[] { 0x53, 0x50, 0x30, 0x31 }, "bin/amazonkindlepack");
            Detectors.Add(new byte[] { 0xBE, 0xBA, 0xFE, 0xCA }, "DBA/palm");
            Detectors.Add(new byte[] { 0x00, 0x01, 0x42, 0x44 }, "DBA/palm");
            Detectors.Add(new byte[] { 0x00, 0x01, 0x44, 0x54 }, "TDA/palm");
            Detectors.Add(new byte[] { 0x54, 0x44, 0x46, 0x24 }, "TDF$/telegram");
            Detectors.Add(new byte[] { 0x54, 0x44, 0x45, 0x46 }, "TDEF/telegram_enc");
            Detectors.Add(new byte[] { 0x00, 0x00, 0x01, 0x00 }, "ICO/icon_file");

            Detectors.Add(new byte[] { 0x1F, 0x9D }, "tar.z/tararchive");
            Detectors.Add(new byte[] { 0x1f, 0xa0 }, "tar.z/tararchive");
            Detectors.Add(new byte[] { 0x42, 0x5a, 0x68 }, "BZ2/archive");
            Detectors.Add(new byte[] { 0x47, 0x49, 0x46, 0x38,
                                       0x37, 0x61}, "GIF/image");
            Detectors.Add(new byte[] { 0x47, 0x49, 0x46, 0x38,
                                       0x39, 0x61}, "GIF/image");
            Detectors.Add(new byte[] { 0x49, 0x49, 0x2a, 0x00 }, "TIF/image");
            Detectors.Add(new byte[] { 0x4D, 0x4D, 0x00, 0x2a }, "TIF/image");
            Detectors.Add(new byte[] { 0xFF, 0xD8, 0xFF, 0xDB }, "JPG/image");
            Detectors.Add(new byte[] { 0xFF, 0xD8, 0xFF, 0xE0,
                                       0x00, 0x10, 0x4A, 0x46,
                                       0x49, 0x46, 0x00, 0x01}, "JPG/image");
            Detectors.Add(new byte[] { 0xFF, 0xD8, 0xFF, 0xEE }, "JPG/image");
            Detectors.Add(new byte[] { 0x4D, 0x5A }, "PE_NE/executable");
            Detectors.Add(new byte[] { 0x50, 0x4B, 0x03, 0x04 }, "ZIP/archive");
            Detectors.Add(new byte[] { 0x50, 0x4B, 0x05, 0x06 }, "ZIP/archive");
            Detectors.Add(new byte[] { 0x50, 0x4B, 0x07, 0x08 }, "ZIP/archive");
            Detectors.Add(new byte[] { 0x52, 0x61, 0x72, 0x21,
                                       0x1a, 0x07, 0x00}, "RAR/archive");
            Detectors.Add(new byte[] { 0x52, 0x61, 0x72, 0x21,
                                       0x1a, 0x07, 0x01, 0x00}, "RAR/archive");
            Detectors.Add(new byte[] { 0x5A, 0x4D }, "DOS/zm_exec");
            Detectors.Add(new byte[] { 0x7F, 0x45, 0x4c, 0x46 }, "ELF/executable");
            Detectors.Add(new byte[] { 0x89, 0x50, 0x4e, 0x47,
                                       0x0d, 0x0a, 0x1a, 0x0a}, "PNG/image");
            Detectors.Add(new byte[] { 0xCA, 0xFE, 0xBA, 0xBE }, "JAVA/class");
            Detectors.Add(new byte[] { 0x25, 0x21, 0x50, 0x53 }, "POSTSCRIPT/doc");
            Detectors.Add(new byte[] { 0x25, 0x50, 0x44, 0x46,
                                       0x2d }, "PDF/doc");
            Detectors.Add(new byte[] { 0x4F, 0x67, 0x67, 0x53 }, "OGG/media");
            Detectors.Add(new byte[] { 0xFF, 0xFB }, "MP3/media");
            Detectors.Add(new byte[] { 0xFF, 0xF3 }, "MP3/media");
            Detectors.Add(new byte[] { 0xFF, 0xF2 }, "MP3/media");
            Detectors.Add(new byte[] { 0x49, 0x44, 0x33 }, "MP3/media");
            Detectors.Add(new byte[] { 0x42, 0x4D }, "BMP/image");
            Detectors.Add(new byte[] { 0x66, 0x4c, 0x61, 0x43 }, "FLAC/media");
            Detectors.Add(new byte[] { 0x4d, 0x54, 0x68, 0x64 }, "MIDI/media");
            Detectors.Add(new byte[] { 0xD0, 0xCF, 0x11, 0xE0,
                                       0xA1, 0xB1, 0x1A, 0xE1 }, "MS/document");
            Detectors.Add(new byte[] { 0x43, 0x72, 0x32, 0x34 }, "GC/extension");
            Detectors.Add(new byte[] { 0x50, 0x4d, 0x4f, 0x43,
                                       0x43, 0x4d, 0x4f, 0x43 }, "WIN/datfile");
            Detectors.Add(new byte[] { 0x37, 0x7a, 0xBC, 0xAF,
                                       0x27, 0x1c }, "7Z/archive");
            Detectors.Add(new byte[] { 0x1f, 0x8b }, "GZIP/archive");
            Detectors.Add(new byte[] { 0x4d, 0x53, 0x43, 0x46 }, "MS/cabinet");
            Detectors.Add(new byte[] { 0x43, 0x57, 0x53 }, "SWF/flash");
            Detectors.Add(new byte[] { 0x46, 0x57, 0x53 }, "SWF/flash");
            Detectors.Add(new byte[] { 0x21, 0x3c, 0x61, 0x72,
                                       0x63, 0x68, 0x3e }, "DEB/linux");
            Detectors.Add(new byte[] { 0x7b, 0x5c, 0x72, 0x74,
                                       0x66, 0x31 }, "RTF/document");
            Detectors.Add(new byte[] { 0x00, 0x00, 0x01, 0xBA }, "MPEG/media");
            Detectors.Add(new byte[] { 0x66, 0x74, 0x79, 0x70,
                                       0x69, 0x73, 0x6f, 0x6d }, "MP4/media");
        }
    }
}
