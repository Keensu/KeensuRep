using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peterson
{
    public class RightPetersonAlgorithm
    {
        private bool[] threadWantsLock = new bool[2];
        private int currentTurn;

        public void AcquireLock(int threadId)
        {
            int otherThread = 1 - threadId;
            threadWantsLock[threadId] = true;
            currentTurn = otherThread;

            while (threadWantsLock[otherThread] && currentTurn == otherThread) { }
        }

        public void ReleaseLock(int threadId)
        {
            threadWantsLock[threadId] = false;
        }
    }
}
