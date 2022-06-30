using WebApplication1.Abstraction;
using WebApplication1.Model;
using System.Globalization;

namespace WebApplication1.Service;

public class Student_Helper : IStudent_Helper
{
    public Student Getstudentbyid(List<Student> students, int id)
    {
        Student requiredid = students.First(obj => obj.id == id);
        return requiredid;
    }

    public List<Student> Getstudentbyname(List<Student> students, string name)
    {
        List<Student> requirednames = students.Where(obj => obj.name == name).ToList();
        return requirednames;
    }

    public string GetDate(string language)
    {
        return DateTime.Now.Date.ToString("MM/dd/yyyy h:mm tt", new CultureInfo(language));
    }

    public List<Student> UpdateStudentName(List<Student> students, int id,String newname)
    {
        foreach (Student s in students)
        {
            if (s.id == id)
            {
                s.name = newname;
            }
        }

        return students;

    }
    
    public List<Student> DeleteStudent(List<Student> students,int id)
    {
        foreach (Student s in students)
        {
            if (s.id == id)
            {
                students.Remove(s);
            }
        }

        return students;

    }
}