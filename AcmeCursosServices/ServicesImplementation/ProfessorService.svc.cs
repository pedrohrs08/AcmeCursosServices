using AcmeCursosServices.DAL;
using AcmeCursosServices.ServicesInterfaces;
using AcmeCursos.Models;
using System.Linq;
using System;
using System.Collections.Generic;

namespace AcmeCursosServices.ServicesImplementation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProfessorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProfessorService.svc or ProfessorService.svc.cs at the Solution Explorer and start debugging.
    public class ProfessorService : CrudImplementation<Professor>, IProfessorService
    {
        public ProfessorService() : base(AppDbContext.db.Professores) {

        }

        public Professor GetProfessorComCursos(int id)
        {
            return db.Professores
                .Include("Cursos")
                .SingleOrDefault(p => p.Id == id);
        }

        public Professor SaveWithCursos(Professor professor, List<int> CursoIds)
        {
            var editedCursos = db.Cursos.Where(curso => CursoIds.Contains(curso.Id)).ToList();
            if (professor.Id == 0)
            {
                professor.Cursos = editedCursos;
                db.Professores.Add(professor);
            }
            else
            {
                Professor dbProfessor = Get(professor.GetId());
                db.Entry(dbProfessor).CurrentValues.SetValues(professor);
                dbProfessor.Cursos = editedCursos;
            }
            db.SaveChanges();
            return professor;
        }
    }
}
