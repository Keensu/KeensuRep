using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveWriter
{
    public class Writer
    {
        public int numCount = 1000000;
        public int numbersForThread = 1000000 / 4;
        public int blockSize = 10000;
        string filePath = "numbers.txt";
        private readonly object fileLock = new object();

        public void Write()
        {
            Thread[] threads = new Thread[4];
            for (int i = 0; i < 4; i++)
            {
                int threadId = i;
                threads[i] = new Thread(() => DoWork(threadId));
                threads[i].Start();
            }
            foreach (var thread in threads)
            {
                thread.Join();
            }
        }
        private void DoWork(int threadId)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode() + threadId);

            int numbersWritten = 0;
            while (numbersWritten < numbersForThread)
            {

                string[] block = new string[blockSize];

                for (int i = 0; i < blockSize; i++)
                {
                    block[i] = random.Next(1, int.MaxValue).ToString();
                }

                lock (fileLock)
                {
                    File.AppendAllLines(filePath, block);
                }

                numbersWritten += blockSize;

                Thread.Sleep(100);
            }
        }
    }
}
