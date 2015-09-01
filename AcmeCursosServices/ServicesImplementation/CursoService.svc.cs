using AcmeCursosServices.DAL;
using AcmeCursosServices.ServicesInterFaces;
using AcmeCursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcmeCursosServices.ServicesImplementation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CursoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CursoService.svc or CursoService.svc.cs at the Solution Explorer and start debugging.
    public class CursoService : CrudImplementation<Curso>, ICursoService
    {
       public CursoService() : base(AppDbContext.db.Cursos)
       {
          
       }

        public Curso GetCursoComProfessores(int id)
        {
            return db.Cursos.Include("Professores").FirstOrDefault(c => c.Id == id);
        }

        public Curso SaveWithProfessores(Curso curso, List<int> ProfessorIds)
        {
            var editedProfessores = db.Professores.Where(professor => ProfessorIds.Contains(professor.Id)).ToList();
            if (curso.Id == 0)
            {
                curso.Professores = editedProfessores;
                db.Cursos.Add(curso);
            }
            else
            {
                Curso dbCurso = Get(curso.GetId());
                db.Entry(dbCurso).CurrentValues.SetValues(curso);
                dbCurso.Professores = editedProfessores;
            }
            db.SaveChanges();
            return curso;
        }
    }
}
