using AcmeCursosServices.ServicesIntefaces;
using AcmeCursos.Models;
using System.ServiceModel;
using System.Collections.Generic;

namespace AcmeCursosServices.ServicesInterFaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICursoService" in both code and config file together.
    [ServiceContract]
    public interface ICursoService : ICrud<Curso>
    {
        [OperationContract]
        Curso GetCursoComProfessores(int id);

        [OperationContract]
        Curso SaveWithProfessores(Curso curso, List<int> ProfessorIds);
    }
}
