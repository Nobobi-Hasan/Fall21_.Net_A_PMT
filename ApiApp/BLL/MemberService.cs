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
    public class MemberService
    {
        public static MemberModel GetLogin(string username, string password)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Member, MemberModel>();
            });
            var mapper = new Mapper(config);
            //var da = DataAccessFactory.MemberDataAcess();
            var data = mapper.Map<MemberModel>(MemberRepo.GetLogin(username, password));
            return data;
        }
    }
}
