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

        public static List<EnrollmentModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Enrollment, EnrollmentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.EnrollmentDataAcess();
            var data = mapper.Map<List<EnrollmentModel>>(da.GetAll());
            return data;
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
