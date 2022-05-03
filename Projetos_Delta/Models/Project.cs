namespace Projetos_Delta.Models;

public class Project
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Request Request { get; set; }

    public int RequestId { get; set; }
    public ICollection<Employee> Employees { get; set; }

    public Project()
    {

    }

    public Project(string name, Request request)
    {
     
        Name = name;
        Request = request;
    }
}

