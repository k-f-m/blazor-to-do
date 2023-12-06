using System.ComponentModel.DataAnnotations;

namespace BlazorToDo.Data.Models
{
    /// <summary>
    /// Represents a to-do item in the application.
    /// </summary>
    public class Todo
    {
        /// <summary>
        /// Gets or sets the unique identifier for the to-do item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the task description for the to-do item.
        /// </summary>
        /// <remarks>
        /// The [Required] attribute is used to specify that a property is required and cannot be null. 
        /// If a user tries to submit a form with a null value for a required property, 
        /// the form will not be valid and an error message will be displayed.
        /// 
        /// The [MaxLength] attribute is used to specify the maximum length of a string property. 
        /// In this case, it is applied to the Task property and limits the length of the string to 30 characters. 
        /// If a user tries to submit a form with a string that exceeds the maximum length, 
        /// the form will not be valid and an error message will be displayed.
        /// </remarks>
        [Required]
        [MaxLength(30)]
        public string Task { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the due date for the to-do item.
        /// </summary>
        public DateTime? DueDate { get; set; }

        [Required]
        public PriorityLevel Priority { get; set; } = PriorityLevel.High;


        /// <summary>
        /// Gets or sets the creation timestamp for the to-do item.
        /// </summary>
        [Required]
        public DateTime CreationTimestamp { get; set; } = DateTime.Now;
    }
}
