using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFramework.Generics
{
    public class CSharpUtility
    {
        /*
         * method to generate random numbers
         */
        public int GenerateRandomNum()
        {
            Random random = new Random();
            int randomNum = random.Next(1000);
            return randomNum;
        }

        /*
         * method to geterate random date and time
         */
        public String GetSystemDateAndTime()
        {
            DateTime date = DateTime.Now;
            return date.ToString();
        }
    }
}
