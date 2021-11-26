using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MemberRepo
    {
        static PMTEntities db;
        static MemberRepo()
        {
            db = new PMTEntities();
        }

        public static Member GetLogin(string username, string password)
        {
            return db.Members.FirstOrDefault(e => e.Username == username && e.Password == password);
        }
    }
}
