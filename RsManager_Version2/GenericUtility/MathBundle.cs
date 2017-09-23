using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUtility
{
    public class MathBundle
    {
        public string GetPairedSum(double[] memBox,double targetSum)
        {
            string msg = "NIL";
            for(int row=0;row<memBox.Length;row++)
            {
                for(int d=row+1;d<memBox.Length;d++)
                {
                    double result = memBox[row] + memBox[d];
                    if(result==targetSum)
                    {
                      
                        msg= string.Format("{0}|{1}",row,d);
                        break;   
                    }
                }
            }
            return msg;
        }
    }
}
