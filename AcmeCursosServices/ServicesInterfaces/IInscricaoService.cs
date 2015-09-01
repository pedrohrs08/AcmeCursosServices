using AcmeCursos.Models;
using AcmeCursosServices.ServicesIntefaces;
using System.ServiceModel;

namespace AcmeCursosServices.ServicesInterfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IInscricaoService" in both code and config file together.
    [ServiceContract]
    public interface IInscricaoService : ICrud<Inscricao>
    {

    }
}
