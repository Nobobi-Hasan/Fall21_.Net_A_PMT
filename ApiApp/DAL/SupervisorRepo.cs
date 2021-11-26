using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupervisorRepo
    {
        static PMTEntities db;
        static SupervisorRepo()
        {
            db = new PMTEntities();
        }

        public static Supervisor GetLogin(string username, string password)
        {
            return db.Supervisors.FirstOrDefault(e => e.Username == username && e.Password == password);
        }
    }
}
