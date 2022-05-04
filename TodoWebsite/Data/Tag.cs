using System.ComponentModel.DataAnnotations;

namespace TodoWebsite.Data
{
    public class Tag {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TodoListId { get; set; }
        public string TagValue { get; set; }
    }
}
