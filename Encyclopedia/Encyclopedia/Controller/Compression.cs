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
    /// <summary>
    /// This class has static methods that support the compression system.
    /// </summary>
    public class Compression
    {
        /// <summary>
        /// Compressed all the Lemmas that are on the database.
        /// </summary>
        public static void CompressAllLemmaFromDatabase()
        {
            //Get all Lemmas from database
            List<Lemma> list = DBConnect.GetAllLemma();
            //Iterate through lemmas
            foreach(Lemma lemma in list)
            {
                //Get the decompressed Lemma body in bytes
                byte[] decompressedBody = lemma.Body;
                //Compress the body to an array of bytes
                byte[] compressedBody = CompressLemmas(decompressedBody);
                //Set lemma body to the compressed array of bytes
                lemma.Body = compressedBody;
                //Try to update the Lemma in database if res != 1 then it fails
                int res = DBConnect.Update(lemma.Title, lemma.Body);
                if(res != 1)
                {
                    MessageBox.Show("Something went wrong with updating lemma!!");
                    return;
                }
                
            }
        }
        /// <summary>
        /// Decompressed all the Lemmas we have in database.
        /// This is a debug only function no use in release.
        /// </summary>
        public static void DecompressAllLemmaFromDatabase()
        {
            //Get all Lemmas from database
            List<Lemma> list = DBConnect.GetAllLemma();
            //Iterate through lemma list
            foreach (Lemma lemma in list)
            {
                //Get the compressed body in bytes
                byte[] compressedBody = lemma.Body;
                //Get the decompress body in bytes
                byte[] decompressedBody = DecompressLemmas(compressedBody);
                //Set the lemma body to the decompressed Body 
                lemma.Body = decompressedBody;
                //Try to update lemma if res != 1 then fail
                int res = DBConnect.Update(lemma.Title, lemma.Body);
                if (res != 1)
                {
                    MessageBox.Show("Something went wrong with updating lemma!!");
                    return;
                }
                
            }
        }
        /// <summary>
        /// This method takes the lemma body as a byte array and compresses it with GZip.
        /// </summary>
        /// <param name="decompressedLemma"></param>
        /// <returns></returns>
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
        /// <summary>
        /// This method takes the compressed Lemma body and decompresses it with GZip.
        /// </summary>
        /// <param name="compressLemma"></param>
        /// <returns></returns>
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
