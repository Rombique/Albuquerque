using System;
using System.ComponentModel.DataAnnotations;

namespace Albuquerque.Core.Models
{
    public class NewIssueModel
    {
        [Required]
        public string Number { get; set; }
        [Required]
        public DateTime Deadline { get; set; }
        public string Comments { get; set; }
    }
}