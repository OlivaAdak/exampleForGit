using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MathLibrary
    {
        private int result; 
        int a, b;
        public int GetResult
        {
            set
            {
                result = value;
            }
            get
            {
                return result;
            }
        }
        public void ADDition(int a, int b)
        {
            
            result = a + b;
            GetResult = result;

        }
        public void AllClear()
        {
            result = 0;
            GetResult = result;
        }
    }
}
