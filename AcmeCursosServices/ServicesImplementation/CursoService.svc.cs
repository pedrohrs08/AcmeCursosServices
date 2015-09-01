using AcmeCursosServices.DAL;
using AcmeCursosServices.ServicesInterFaces;
using AcmeCursos.Models;

namespace AcmeCursosServices.ServicesImplementation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CursoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CursoService.svc or CursoService.svc.cs at the Solution Explorer and start debugging.
    public class CursoService : CrudImplementation<Curso>, ICursoService
    {
       public CursoService() : base(AppDbContext.db.Cursos)
       {
          
       }
    }
}
