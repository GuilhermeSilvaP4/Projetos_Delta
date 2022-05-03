namespace Projetos_Delta.Models;

public class Employee
{
    public int ID { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Departamento { get; set; }

    public ICollection<Request> Requests { get; set; }

    public ICollection<Projeto> Projetos { get; set; }
}
