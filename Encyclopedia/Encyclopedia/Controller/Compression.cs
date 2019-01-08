using Encyclopedia.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encyclopedia.Controller
{
    public class Compression
    {
        public static void CompressAllLemmaFromDatabase()
        {
            List<Lemma> list = DBConnect.GetAllLemma();

            foreach(Lemma l in list)
            {
                byte[] decomp = l.Body;

                byte[] comp = CompressLemmas(decomp);

                l.Body = comp;

                int res = DBConnect.Update(l.Title, l.Body);
                if(res != 1)
                {
                    MessageBox.Show("Something went wrong with updating lemma!!");
                    return;
                }
                
            }
        }

        public static void DecompressAllLemmaFromDatabase()
        {
            List<Lemma> list = DBConnect.GetAllLemma();

            foreach (Lemma l in list)
            {
                byte[] comp = l.Body;

                byte[] dec = DecompressLemmas(comp);

                l.Body = dec;

                int res = DBConnect.Update(l.Title, l.Body);
                if (res != 1)
                {
                    MessageBox.Show("Something went wrong with updating lemma!!");
                    return;
                }
                
            }
        }

        public static byte[] CompressLemmas(byte[] decompressedLemma)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                using (GZipStream gzip = new GZipStream(memory,
                    CompressionMode.Compress, true))
                {
                    gzip.Write(decompressedLemma, 0, decompressedLemma.Length);
                }
                return memory.ToArray();
            }
        }


        public static byte[] DecompressLemmas(byte[] compressLemma)
        {
            // Create a GZIP stream with decompression mode.
            // ... Then create a buffer and write into while reading from the GZIP stream.
            using (GZipStream stream = new GZipStream(new MemoryStream(compressLemma),
                CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];
                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }
                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }
    }
}
