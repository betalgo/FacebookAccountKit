using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAccountKit.AccountKitResponseModels
{
    public class AccountKitToken
    {
        public string id { get; set; }
        public string access_token { get; set; }
        public int token_refresh_interval_sec { get; set; }
    }
}
