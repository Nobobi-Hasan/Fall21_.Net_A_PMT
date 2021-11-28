using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static PMTEntities db;
        static DataAccessFactory()
        {
            db = new PMTEntities();
        }

        public static IRepo<Project, int, string> ProjectDataAcess()
        {
            return new ProjectRepo(db);
        }


        public static IRepo<Enrollment, int, int, string> EnrollmentDataAcess()
        {
            return new EnrollmentRepo(db);
        }
    }
}
