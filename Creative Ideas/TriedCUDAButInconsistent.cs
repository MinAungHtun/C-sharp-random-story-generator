using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cudafy;
using Cudafy.Host;
using Cudafy.Translator;

namespace Creative_Ideas
{
    class TriedCUDAButInconsistent
    {
        Random random = new Random();
        int q, w, e, r, t;
        public int G1(int a, int b)
        {
            q=random.Next(a,b);
            return q;
        }
        public int G2(int a, int b)
        {
            w=random.Next(a,b);
            return w;
        }
        public int G3(int a, int b)
        {
            e = random.Next(a, b);
            return e;
        }
        public int G4(int a, int b)
        {
            r = random.Next(a, b);
            return r;
        }
        public int G5(int a, int b)
        {
            t = random.Next(a, b);
            return r;
        }
        
    }
}
