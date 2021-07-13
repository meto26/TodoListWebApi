using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        [NotMapped]
        public ICollection<TodoItem> TodoItems { get; set; }
        public Category()
        {
            TodoItems = new HashSet<TodoItem>();
            
        }
    }
}
