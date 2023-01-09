using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOrder
{
    internal class GlobalVar  
        //Global Variable全域變數,整個專案都可以看到的變數
    {
        public static int memberID = 0;
        public static string strLoginName = "";
        public static string intKeyLevel = ""; //會員:1 ,店員:10, 店長:100 , 系統管理員= 1000;

    }
}
