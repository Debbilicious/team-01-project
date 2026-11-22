using System.ComponentModel.DataAnnotations;

namespace StudyPlanner.Models;

public enum Priority { Low = 1, Medium = 2, High = 3 }

public class Assignment
{
    public int Id { get; set; }

    [Required, StringLength(150, MinimumLength = 2)]
    public string Title { get; set; } = "";

    [DataType(DataType.Date)]
    public DateTime DueDate { get; set; } = DateTime.Today.AddDays(7);

    public Priority Priority { get; set; } = Priority.Medium;

    [StringLength(1000)]
    public string? Notes { get; set; }

    public bool IsComplete { get; set; }

    public int CourseId { get; set; }
    public Course? Course { get; set; }

    // The id of the student who owns this assignment
    public string OwnerId { get; set; } = "";
}
