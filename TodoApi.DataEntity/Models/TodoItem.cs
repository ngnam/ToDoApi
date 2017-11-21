using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.DataEntity.Interface;

namespace TodoApi.DataEntity.Models
{
    public class TodoItem : Entity
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }        
    }
}
