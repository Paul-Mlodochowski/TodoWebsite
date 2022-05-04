using System.Collections.Generic;

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
    }
}
