using System.ComponentModel.DataAnnotations;

namespace Projetos_Delta.Models;

public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    [Required(ErrorMessage = "{0} required")]
    [EmailAddress(ErrorMessage = "Enter a valid email")]
    public string Email { get; set; }

    public string Departamento { get; set; }

    public ICollection<Request> Requests { get; set; }

    public ICollection<Project> Projects { get; set; }

    public Employee()
    {

    }

    public Employee( string name, string email, string departamento)
    {
        
        Name = name;
        Email = email;
        Departamento = departamento;
    }
}
