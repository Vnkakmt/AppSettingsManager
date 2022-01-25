using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSettingsManager.Models
{
    public class TwilioSettings
    {
        //property names should match the key names in appsettings
        public string AuthToken { get; set; }
        public string AccountSid { get; set; }
        public string PhoneNumber { get; set; }

    }
}
