using AcmeCursosServices.ServicesIntefaces;
using AcmeCursos.Models;
using System.ServiceModel;

namespace AcmeCursosServices.ServicesInterfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEstudanteService" in both code and config file together.
    [ServiceContract]
    public interface IEstudanteService : ICrud<Estudante>
    {

        [OperationContract]
        Estudante GetEstudanteComCursos(int id);
    }
}
