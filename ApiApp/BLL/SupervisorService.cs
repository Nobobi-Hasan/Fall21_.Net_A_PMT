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
    public class SupervisorService
    {
        public static SupervisorModel GetLogin(string username, string password)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Supervisor, SupervisorModel>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.MemberDataAcess();
            var data = mapper.Map<SupervisorModel>(SupervisorRepo.GetLogin(username, password));
            return data;
        }
    }
}
