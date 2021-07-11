using System;

namespace TodoApi.Models
{
    public class TodoItem
    {
        /// <summary>
        /// �tem id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// �tem name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// �tem iscompleted or not
        /// </summary>
        public bool IsComplete{get;set; }
        /// <summary>
        /// �tem time
        /// </summary>
        public DateTime Time { get; set; }
        
    }
}