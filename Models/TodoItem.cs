using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    public class TodoItem
    {
        /// <summary>
        /// �tem id
        /// </summary>
        [JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long Id { get; set; }
        /// <summary>
        /// �tem name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// �tem iscompleted or not
        /// </summary>
        public bool IsComplete{ get; set; }
        /// <summary>
        /// �tem time
        /// </summary>
        [JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime Time { get; set; } = DateTime.Now;
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}