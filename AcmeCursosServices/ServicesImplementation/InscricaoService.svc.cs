using AcmeCursosServices.ServicesInterfaces;
using AcmeCursos.Models;
using AcmeCursosServices.DAL;

namespace AcmeCursosServices.ServicesImplementation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InscricaoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InscricaoService.svc or InscricaoService.svc.cs at the Solution Explorer and start debugging.
    public class InscricaoService : CrudImplementation<Inscricao>, IInscricaoService
    {
        public InscricaoService() : base(AppDbContext.db.Inscricoes) {

        }
    }
}
