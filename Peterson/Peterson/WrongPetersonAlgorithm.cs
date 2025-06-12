using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peterson
{
    public class WrongPetersonAlgorithm
    {
        private bool[] threadWantsLock = new bool[2];
        private int currentTurn;

        public void AcquireLock(int threadId)
        {
            int otherThread = 1 - threadId;
            threadWantsLock[threadId] = true;

            while (threadWantsLock[otherThread] && currentTurn == otherThread) { }
            currentTurn = otherThread;
        }

        public void ReleaseLock(int threadId)
        {
            threadWantsLock[threadId] = false;
        }
    }
}
