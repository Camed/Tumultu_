﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumultu_.Entropy
{
    public class EntropyCounter
    {
        FileStream fs;
        private readonly int NUM_OF_SAMPLES = 256;
        private long sampleSize = 0;
        private long fileSize = 0;

        public EntropyCounter(FileStream fs, int samples = 256)
        {
            NUM_OF_SAMPLES = samples;
            this.fs = fs;
            fileSize = fs.Length;
            sampleSize = fileSize / samples;
        }

        public EntropyCounter(string path, int samples = 256)
        {
            NUM_OF_SAMPLES = samples;
            this.fs = new FileStream(path, FileMode.Open);
            fileSize = fs.Length;
            sampleSize = fileSize / samples;
        }

        private double GetSampleEntropy(byte[] bytes)
        {
            Dictionary<byte, int> histogram = new Dictionary<byte, int>();
            for(byte b = 0; b <= 0xFF; b++)
                histogram.Add(b, 0);
            
            foreach(byte b in bytes)
                histogram[b]++;

            double entropy = 0;
            foreach (var b in histogram)
            {
                entropy += ((double)b.Value * b.Value) / bytes.Length;
            }
            entropy = 1 - (entropy / bytes.Length);
            return entropy * entropy;
        }

        public List<double> GetFileEntropy()
        {
            List<double> entropyFragments = new List<double>();

            for(int i = 0; i < NUM_OF_SAMPLES; i++)
            {
                byte[] byteArray = new byte[sampleSize];
                for(int j = 0; j < sampleSize; j++)
                {
                    byteArray[j] = (byte)fs.ReadByte();
                }
                entropyFragments.Add(GetSampleEntropy(byteArray));
            }

            return entropyFragments;
        }
    }
}