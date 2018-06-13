using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instruments;

namespace _7_num_seq
{
    class Sequence
    {
        int n;
        double minSqr;
        public int N
        {
            get => n;
            set
            {
                if (Validator.IsPositive(value)) n = value;
            }
        }

        public double MinSqr
        {
            get => minSqr;
            set
            {
                if (Validator.IsPositive(value)) minSqr = value;
            }
        }

        public Sequence(int N, double MinSqr)
        {
            this.N = N;
            this.MinSqr = MinSqr;
            GetSeq();
        }

        public String SeqStr { get; private set; }
        private void GetSeq()
        {
            int first = GetFirstElem(MinSqr);
            String result = "";
            for (int i = 0; i < N; i++)
            {
                result += first;
                first++;
                if (i + 1 != N) result += ", ";
            }
            SeqStr = result;
        }

        private int GetFirstElem(double minSqr)
        {
            double result = Math.Sqrt(minSqr) + 1;
            return (int)result;
        }
    }
}
