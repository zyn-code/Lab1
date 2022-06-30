using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Abstraction;

public interface IStudent_Helper
{
    public Student Getstudentbyid(List<Student> students, int id); 
    public List<Student> Getstudentbyname(List<Student> students, string name);

    public string GetDate(string language);
    public List<Student> UpdateStudentName(List<Student> students, int id, string name);
    public List<Student> DeleteStudent(List<Student> students, int id);

}