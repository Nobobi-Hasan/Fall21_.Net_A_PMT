using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EnrollmentService
    {
        public static void Add(int pId, int mId)
        {
            DataAccessFactory.EnrollmentDataAcess().Add(pId, mId);
        }

        public static void Confirm(int eId)
        {
            DataAccessFactory.EnrollmentDataAcess().Confirm(eId);
        }

        public static void Decline(int eId)
        {
            DataAccessFactory.EnrollmentDataAcess().Decline(eId);
        }
    }
}
