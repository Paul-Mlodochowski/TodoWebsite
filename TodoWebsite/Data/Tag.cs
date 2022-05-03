using System.ComponentModel.DataAnnotations;

namespace TodoWebsite.Data
{
    public class Tag {
        [Key]
        public int Id { get; set; }
        public string TagValue { get; set; }
    }
}
