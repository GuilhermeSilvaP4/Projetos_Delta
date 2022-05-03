namespace Projetos_Delta.Models;

public class Request
{
    public int Id { get; set; }

    public int RequestNumber { get; set; }
    public string Name  { get; set; }

    public DateTime Date { get; set; }

    public ICollection<Project> Projects { get; set; }

    public Request()
    {
    
    }

    public Request(int requestNumber, string name, DateTime date)
    {
      
        RequestNumber = requestNumber;
        Name = name;
        Date = date;
    }
}
