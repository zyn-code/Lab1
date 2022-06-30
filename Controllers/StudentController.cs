using Microsoft.AspNetCore.Mvc;
using WebApplication1.Abstraction;
using WebApplication1.Model;
using WebApplication1.Service;

namespace WebApplication1.Controllers;
[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudent_Helper _helper;    
    public StudentController(IStudent_Helper studentHelper)
    {
        _helper = studentHelper;
    } 
    private static readonly List<Student> students = new List<Student>();
    
    [HttpGet("first")]
    public IEnumerable<Student> Getstudents()
    {
        return students;
    }
    [HttpPost("PostAdd")]
    public IEnumerable<Student> Postudents([FromBody] Student s)
    {
        students.Add(s);
        return Getstudents();
    }
    
    [HttpGet("{id:int}")]
    public Student Getstudentbyid([FromRoute]int id)
    {
        return _helper.Getstudentbyid(students,id);
    }
    [HttpGet("names/{name}")]

    public IEnumerable<Student> Getstudentbyname([FromQuery] String name)
    {

         return _helper.Getstudentbyname(students,name);
    }
    [HttpGet("language/{language}")]
    public String GetEndpoint([FromRoute]String language)
    {
        return _helper.GetDate(language);
    }
    
    [HttpPost("name/{name},id/{id}")]
    public List<Student> UpdateStudentName([FromRoute] int id,String name)
    {
        return _helper.UpdateStudentName(students, id, name);
    }
    [HttpDelete("id/{id}")]
    public List<Student> DeleteStudent([FromBody]int id)
    {
        return _helper.DeleteStudent(students, id);
    }

}