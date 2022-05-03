
using Projetos_Delta.Models;

namespace Projetos_Delta.Data;

public class SeedingService
{
    public static void Seed(Projetos_DeltaContext _context)
    {
        if (_context.Projetos.Any() ||
           _context.Requests.Any() ||
           _context.Employees.Any())
        {
            return; //DB has been seeded
        }
        Request r1 = new(  001, "Vivo 2022", new DateTime(2022, 01, 15));
        Request r2 = new( 002, "TIM 2022", new DateTime(2022, 02, 25));
        Request r3 = new( 003, "OI 2022", new DateTime(2022, 01, 04));
        Request r4 = new( 004, "Claro 2022", new DateTime(2022, 02, 15));

        Project p1 = new ( "Vivo", r1);
        Project p2 = new ( "Vivo", r2);
        Project p3 = new ( "Vivo", r3);
        Project p4 = new ( "Vivo", r4);

        Employee e1 = new("Guilherme Silva", "guilherme.silva@deltaww.com", "Engenharia");
        Employee e2 = new("Bruno Inácio", "bruno.ferreira@deltaww.com", "Engenharia");
        Employee e3 = new("Douglas Cruz", "douglas.cruz@deltaww.com", "Engenharia");
        Employee e4 = new("Renato Valério", "renato.valerio@deltaww.com", "Engenharia");

        _context.AddRange(r1, r2, r3, r4);
        _context.AddRange(p1, p2, p3, p4);
        _context.AddRange(e1, e2, e3, e4);

        _context.SaveChanges();



    }
}
