using System;
using System.Collections.Generic;
using System.Globalization;

namespace Pivotal_WebApp.Pages
{
    public class my_region
    {
        public string location;
        public string culture;
        public string local_time_localised;
        public string status;

        public my_region(string loc, string cul, int adj)
        {
            DateTime region_local_time = DateTime.Now.AddHours(adj);

            this.location = loc;
            this.culture = cul;
            this.local_time_localised = region_local_time.ToString(new CultureInfo(cul));

            this.status = "Unknown";

            if (region_local_time.Hour >= 9 && region_local_time.Hour < 18)
            {
                this.status = "Office Open";
            }
            else
            {
                this.status = "* Outside working hours *";
            }

        }
    }
}