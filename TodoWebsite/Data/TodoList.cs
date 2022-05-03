using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoWebsite.Data
{
    [Table("TodoLists")]
    public class TodoList {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public List<Tag> Tags { get; set; }
        public bool IsDone { get; set; }
    }
}
