using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAdd_Ex4_4
{
    internal class BMath:AMath
    {
        public int Add(int[] numAry)
        {
            int sum = 0;
            for (int i = 0; i < numAry.Length; i++)
            {
                sum += numAry[i];
            }
            return sum;
        }
    }
}
