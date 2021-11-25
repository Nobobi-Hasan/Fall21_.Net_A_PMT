using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ProjectRepo : IRepo<Project, int, string>
    {
        PMTEntities db;
        public ProjectRepo(PMTEntities db)
        {
            this.db = db;
        }

        public void Add(Project e)
        {
            db.Projects.Add(e);
            db.SaveChanges();
        }

        public void Delete(Project e)
        {
            var n = db.Projects.FirstOrDefault(en => en.Id == e.Id);
            db.Projects.Remove(n);
            db.SaveChanges();
        }

        public void Edit(Project e)
        {
            var n = db.Projects.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(n).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Project> GetAll()
        {
            return db.Projects.ToList();
        }

        public Project GetById(int id)
        {
            return db.Projects.FirstOrDefault(e => e.Id == id);
        }

        public List<Project> GetByStatus(string status)
        {
           
            var entity = (from e in db.Projects
                          where e.Status == status
                          select e).ToList();
            return entity;
        }

        public List<Project> GetByMIdStatus(int id, string status)
        {
            var project = new List<Project>();

           
            var projectsS = (from e in db.Projects
                          where e.Status == status
                          select e).ToList();

            foreach(var p in projectsS)
            {
                var enrollment = db.Enrollments.FirstOrDefault(e => e.MemberId == id && e.ProjectId == p.Id);
                var pr = db.Projects.FirstOrDefault(e => e.Id == enrollment.ProjectId);
                project.Add(pr);
            }

            return project;
        }

        public List<Project> GetByMIdApplied(int id)
        {
            var project = new List<Project>();

            var enrollments = (from e in db.Enrollments
                                where e.Status == "Applied"
                                && e.MemberId == id
                                select e).ToList();

            foreach (var en in enrollments)
            {
                var pr = db.Projects.FirstOrDefault(e => e.Id == en.ProjectId);
                project.Add(pr);
            }
            return project;
        }
    }
}
