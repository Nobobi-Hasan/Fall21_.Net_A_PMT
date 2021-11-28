using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class MemberController : ApiController
    {
       


        [Route("api/Member/OpenProjects")]
        [HttpGet]
        public List<ProjectModel> GetByStatus()
        {
            return ProjectService.GetByStatus("Open");
        }

        [Route("api/Member/Enroll/{pId}")]
        [HttpPost]
        public void Add(int pId)
        {
            EnrollmentService.Add(pId, 5);
        }


        [Route("api/Member/Project/Applied")]
        [HttpGet]
        public List<ProjectModel> GetByMIdApplied()
        {
            return ProjectService.GetByMIdApplied(2);
        }

        [Route("api/Member/Project/{status}")]
        [HttpGet]
        public List<ProjectModel> GetByMIdStatus(string status)
        {
            return ProjectService.GetByMIdStatus(2, status);
        }
    }
}
