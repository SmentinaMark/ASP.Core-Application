using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASP.Core_Application.Models
{
    public class ToDoItem
    {
        public Guid Id { get; set; } //random long string of letters and numbers
        public bool IsDone { get; set; }

        [Required] // can not be null or empty
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
    }
}
