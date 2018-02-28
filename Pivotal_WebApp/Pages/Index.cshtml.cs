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

            region_list_populated.Add(new my_region("Atlanta", "en-US", -5));
            region_list_populated.Add(new my_region("Beaverton", "en-US", -8));
            region_list_populated.Add(new my_region("Boulder", "en-US", -7));
            region_list_populated.Add(new my_region("Cambridge", "en-US", -5));
            region_list_populated.Add(new my_region("Chicago", "en-US", -6));
            region_list_populated.Add(new my_region("Dallas", "en-US", -6));
            region_list_populated.Add(new my_region("Denver", "en-US", -7));
            region_list_populated.Add(new my_region("Los Angeles", "en-US", -8));
            region_list_populated.Add(new my_region("Palo Alto", "en-US", -8));
            region_list_populated.Add(new my_region("Raleigh", "en-US", -5));
            region_list_populated.Add(new my_region("San Francisco", "en-US", -8));
            region_list_populated.Add(new my_region("São Paulo", "pt-BR", -3));
            region_list_populated.Add(new my_region("Seattle", "en-US", -8));
            region_list_populated.Add(new my_region("Toronto", "en-CA", -8));
            region_list_populated.Add(new my_region("Washington D.C.", "en-US", -5));
            region_list_populated.Add(new my_region("Cork", "en-GB", 0));
            region_list_populated.Add(new my_region("Berlin", "de-DE", +1));
            region_list_populated.Add(new my_region("Paris", "fr-FR", +1));
            region_list_populated.Add(new my_region("Beijing", "zh-CN", +8));
            region_list_populated.Add(new my_region("Shanghai", "zh-CN", +8));
            region_list_populated.Add(new my_region("Seoul", "ko-KR", +9));
            region_list_populated.Add(new my_region("Sydney", "en-AU", +11));
            region_list_populated.Add(new my_region("Tokyo", "ja-JP", +9));


            return region_list_populated;
        }


        public void OnGet()
        {
            Message = "hello";

            All_regions = List_all_Regions();
        }
    }
}

