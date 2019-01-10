using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetBanking.Controllers
{
    public class JsonReturnMsg
    {
        public string msg;
        public JsonReturnMsg(string message)
        {
            msg = message;
        }
    }
}
