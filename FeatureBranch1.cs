using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incremental_testbed
{
    internal class FeatureBranch1
    {
        private int MeaningOfLife = 42;

        public void DoWork()
        {
            Console.WriteLine("Hello from feature branch #1");
        }

        private bool UselessInFirstPR = true;

        //
    }
}
