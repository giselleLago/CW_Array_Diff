using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_Array_Diff
{

    public class Kata
    {
        public int[] ArrayDiff(int[] a, int[] b)
        {
            var list = new List<int>();
            for (int y = 0; y < b.Length; y++)
            {
                for (int x = 0; x < a.Length; x++)
                {
                    if (!b.Contains(a[x]))
                    {
                        list.Add(a[x]);
                    }
                }
            }
            var ab = list.ToArray();
            return ab;
        }
    }
}
