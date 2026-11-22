using System.ComponentModel.DataAnnotations;

namespace StudyPlanner.Models;

public class Course
{
    public int Id { get; set; }

    [Required, StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = "";

    [StringLength(20)]
    public string? Code { get; set; }

    [StringLength(40)]
    public string? Term { get; set; }

    // The id of the student who owns this course (set by the app, never typed by the user)
    public string OwnerId { get; set; } = "";

    public List<Assignment> Assignments { get; set; } = new();
}
