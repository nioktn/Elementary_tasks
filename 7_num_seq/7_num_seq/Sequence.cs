using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _7_num_seq
{
    public static class Sequence
    {
        public static String GetSeqString(int N, double minSqr)
        {
            int first = GetFirstElem(minSqr);
            String result = "";
            for (int i = 0; i < N; i++)
            {
                result += first;
                first++;
                if (i + 1 != N) result += ", ";
            }
            return result;
        }

        private static int GetFirstElem(double minSqr)
        {
            double result = Math.Sqrt(minSqr) + 1;
            return (int)result;
        }
    }
}
