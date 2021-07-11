using System;

namespace TodoApi.Models
{
    public class TodoItem
    {
        /// <summary>
        /// Ýtem id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Ýtem name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ýtem iscompleted or not
        /// </summary>
        public bool IsComplete{get;set; }
        /// <summary>
        /// Ýtem time
        /// </summary>
        public DateTime Time { get; set; }
        
    }
}