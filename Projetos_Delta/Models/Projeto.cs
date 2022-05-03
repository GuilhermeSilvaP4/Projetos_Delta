namespace Projetos_Delta.Models;

public class Projeto
{
    public int ID { get; set; }

    public string Name { get; set; }

    public ICollection<Request> Request{ get; set; }

    public ICollection<Employee> Employees { get; set; }
}

