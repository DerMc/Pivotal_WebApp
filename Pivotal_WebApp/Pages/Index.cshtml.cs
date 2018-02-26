using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pivotal_WebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public List<my_region> All_regions { get => all_regions; set => all_regions = value; }

        private List<my_region> all_regions;

        public List<my_region> List_all_Regions()
        {
            DateTime localDate = DateTime.Now;

            List<my_region> region_list_populated = new List<my_region>();

            region_list_populated.Add(new my_region("San Francisco", "en-US", -8));
            region_list_populated.Add(new my_region("New York", "en-US", -5));
            region_list_populated.Add(new my_region("London", "en-GB", 0));
            region_list_populated.Add(new my_region("Dublin", "en-GB", 0));
            region_list_populated.Add(new my_region("Singapore", "en-SG", +8));

            return region_list_populated;
        }


        public void OnGet()
        {
            Message = "hello";

            All_regions = List_all_Regions();
        }
    }
}

