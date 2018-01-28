using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSU_Events
{
    public class Api
    {
        public string version { get; set; }
        public string cal_url { get; set; }
        public string encoding { get; set; }
        public DateTime generated { get; set; }
        public string contents { get; set; }
    }

    public class Categories
    {
        public string __invalid_name__1 { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
        public string title { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_end { get; set; }
        public string venue_id { get; set; }
        public string venue_name { get; set; }
        public string venue_add { get; set; }
        public string venue_add2 { get; set; }
        public string venue_city { get; set; }
        public string venue_region { get; set; }
        public string venue_postal { get; set; }
        public string venue_country { get; set; }
        public string venue_lat { get; set; }
        public string venue_lon { get; set; }
        public string contact { get; set; }
        public string contact_email { get; set; }
        public string contact_phone { get; set; }
        public string image { get; set; }
        public string billboard { get; set; }
        public string series_id { get; set; }
        public string registration { get; set; }
        public string registration_url { get; set; }
        public Categories categories { get; set; }
    }

    public class RootObject
    {
        public Api api { get; set; }
        public List<Data> Data { get; set; }
    }
}
