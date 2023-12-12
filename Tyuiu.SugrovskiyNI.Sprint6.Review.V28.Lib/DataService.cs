using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SugrovskiyNI.Sprint6.Review.V22.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int c, int k, int l)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            if (c < 0 || c >= rows || k < 0 || l >= cols || k > l)
            {
                throw new ArgumentException("Invalid input parameters.");
            }

            int count = 0;
            for (int j = 0; j < cols; j++)
            {
                if (j < k || j > l || j == k)
                {
                    if (array[c, j] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
