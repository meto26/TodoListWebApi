using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class TodoItem
    {
        /// <summary>
        /// Ýtem id
        /// </summary>
        [JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long Id { get; set; }
        /// <summary>
        /// Ýtem name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ýtem iscompleted or not
        /// </summary>
        public bool IsComplete{ get; set; }
        /// <summary>
        /// Ýtem time
        /// </summary>
        [JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime Time { get; set; } = DateTime.Now;
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}