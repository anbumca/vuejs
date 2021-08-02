using System;
using System.Collections.Generic;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/20/2021 11:24:32 AM 
*/

namespace Job.Console.Models.LearningCourseCategory
{
    public class CourseCategoryResponseModel
    {
        public Data data { get; set; }
        public string version { get; set; }
        public Extra_data extra_data { get; set; }
    }

    public class Data
    {
        public List<Items> items { get; set; }
        public int? count { get; set; }
        public bool? has_more_data { get; set; }
        public string cursor { get; set; }
        public int? current_page { get; set; }
        public int? current_page_size { get; set; }
        public int? total_page_count { get; set; }
        public int? total_count { get; set; }
    }
    public class Items
    {
        public int id { get; set; }
        public string code { get; set; }
        public string title { get; set; }
        public bool? has_child { get; set; }
        public int? lev { get; set; }
        public int? iLeft { get; set; }
        public int? iRight { get; set; }
        public string icon { get; set; }
    }

    public class Extra_data
    {
        public int? id { get; set; }
        public string title { get; set; }
        public string title_parent { get; set; }
        public int? id_parent { get; set; }
        public int? lev { get; set; }
        public int? iLeft { get; set; }
        public int? iRight { get; set; }
        public bool? is_root { get; set; }
        public int? root_node_id { get; set; }
    }
}
