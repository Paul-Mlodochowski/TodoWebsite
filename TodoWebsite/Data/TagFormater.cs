using System.Collections.Generic;
using System.Text;

namespace TodoWebsite.Data
{
    public static class TagFormater
    {
        public static List<Tag> ReturnListOfFormatedTags(string text) {
            var list = new List<Tag>();
            text = text.Trim();
            var textArray = text.Split(' ');
            foreach (var tag in textArray) {
                if (tag == "")
                    continue;
                list.Add(new Tag() 
                {
                    TagValue = tag.Insert(0, "#")
                });
            }
            return list;


        }
        public static string ReturnStringOfUnFormatedTags(List<Tag> tags) {
            
            StringBuilder sb = new StringBuilder();
            foreach (var tag in tags) {
                sb.Append(tag.TagValue.Remove(0, 1));
                sb.Append(" ");
            }
            return sb.ToString();


        }
    }
}
