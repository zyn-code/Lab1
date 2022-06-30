using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model;

public class Student
{
    [Required(ErrorMessage = "Please enter your id ")]
    public long id { get; set; }

    public String name { get; set; }
    [Required(ErrorMessage = "Please enter your email ")]

    public String email { get; set; }

    public String language { get; set; }

}