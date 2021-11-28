using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class EnrollmentRepo : IRepo<Enrollment, int, int, string>
    {

        PMTEntities db;
        public EnrollmentRepo(PMTEntities db)
        {
            this.db = db;
        }

        public void Add(int pId, int mId)
        {
            var e = new Enrollment();
            e.ProjectId = pId;
            e.MemberId = mId;
            e.Status = "Applied";

            db.Enrollments.Add(e);
            db.SaveChanges();
        }

        public List<Enrollment> GetAll()
        {
            return db.Enrollments.ToList();
        }



        public void Confirm(int eId)
        {
            var enrollment = db.Enrollments.FirstOrDefault(enr => enr.Id == eId);

            var project = db.Projects.FirstOrDefault(pr => pr.Id == enrollment.ProjectId);
            if (project.Status == "Open")
            {
                //db.Entry(n).CurrentValues.SetValues(e);
                enrollment.Status = "Confirmed";
                db.SaveChanges();
            }
            else
            {
                //db.Entry(n).CurrentValues.SetValues(e);
                enrollment.Status = "Declined";
                db.SaveChanges();
            }
        }

        public void Decline(int eId)
        {
            var enrollment = db.Enrollments.FirstOrDefault(enr => enr.Id == eId);
            enrollment.Status = "Declined";
            db.SaveChanges();
        }
    }
}
