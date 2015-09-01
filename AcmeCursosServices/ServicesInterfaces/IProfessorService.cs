using AcmeCursosServices.ServicesIntefaces;
using AcmeCursos.Models;
using System.ServiceModel;
using System.Collections.Generic;

namespace AcmeCursosServices.ServicesInterfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProfessorService" in both code and config file together.
    [ServiceContract]
    public interface IProfessorService : ICrud<Professor>
    {
        [OperationContract]
        Professor GetProfessorComCursos(int id);

        [OperationContract]
        Professor SaveWithCursos(Professor professor, List<int> CursoIds);
    }
}
