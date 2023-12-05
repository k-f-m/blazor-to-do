using System.ComponentModel.DataAnnotations;

namespace BlazorToDo.Data.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Task { get; set; } = string.Empty;

        public DateTime? DueDate { get; set; }

        [Required]
        public DateTime CreationTimestamp { get; set; } = DateTime.Now;
    }
}
