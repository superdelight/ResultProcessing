using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultBusinessLogic.Utility
{
    public class BusinessBase
    {
       public string Message { get; set; }
       public ResponseCode Response { get; set; }
    }
    public enum ResponseCode
    {
        OK,
        NotOk,
        Error
        
    }
    public class BusinessMessage<T>:BusinessBase
    {
       public  T Result { get; set; }
    }
}
