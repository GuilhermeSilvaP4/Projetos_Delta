namespace Projetos_Delta.Models;

public class Request
{
    public int ID { get; set; }

    public int RequestNuber { get; set; }
    public string Name  { get; set; }

    public DateTime Date { get; set; }

    public Projeto projeto { get; set; }

    public Request()
    {
    
    }

    public Request(int iD, int requestNuber, string? name, DateTime date)
    {
        ID = iD;
        RequestNuber = requestNuber;
        Name = name;
        Date = date;
    }
}
