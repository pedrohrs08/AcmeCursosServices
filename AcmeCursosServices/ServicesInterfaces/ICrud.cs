using System.Collections.Generic;
using System.ServiceModel;
using AcmeCursos.Models;

namespace AcmeCursosServices.ServicesIntefaces
{
    [ServiceContract]
    public interface ICrud<T> where T : GenericEntity
    { 
        [OperationContract]
        T Get(int id);

        [OperationContract]
        List<T> GetAll();

        [OperationContract]
        bool Delete(int id);

        [OperationContract]
        T Save(T entity);
    }
}
