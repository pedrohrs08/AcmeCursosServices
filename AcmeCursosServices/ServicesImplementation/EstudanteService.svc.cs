using System.Linq;
using AcmeCursosServices.DAL;
using AcmeCursosServices.ServicesInterfaces;
using AcmeCursos.Models;

namespace AcmeCursosServices.ServicesImplementation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EstudanteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EstudanteService.svc or EstudanteService.svc.cs at the Solution Explorer and start debugging.
    public class EstudanteService : CrudImplementation<Estudante>, IEstudanteService
    {
        public EstudanteService() : base(AppDbContext.db.Estudantes)
        {

        }

        public Estudante GetEstudanteComCursos(int id)
        {
            Estudante estudante =  db.Estudantes
                .Include("Inscricoes")
                .Include("Inscricoes.Curso")
                .SingleOrDefault(e => e.Id == id);
            return estudante;
        }
    }
}
