using AcmeCursosServices.ServicesIntefaces;
using AcmeCursos.Models;
using System.ServiceModel;

namespace AcmeCursosServices.ServicesInterFaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICursoService" in both code and config file together.
    [ServiceContract]
    public interface ICursoService : ICrud<Curso>
    {

    }
}
