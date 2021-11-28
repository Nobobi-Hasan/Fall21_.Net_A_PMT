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
    public class SupervisorController : ApiController
    {
        [Route("api/Project/Create")]
        [HttpPost]
        public void Add(ProjectModel n)
        {
            //string sId = User.Identity.Name;
            //int id = Int32.Parse(sId);
            //n.SupervisorId = id;
            ProjectService.Add(n);
        }



        [Route("api/Project/All")]
        [HttpGet]
        public List<ProjectModel> GetAll()
        {
            return ProjectService.GetAll();
        }


        [Route("api/Project/GetById/{id}")]
        [HttpGet]
        public ProjectModel GetById(int id)
        {
            return ProjectService.GetById(id);
        }

        [Route("api/Project/{status}")]
        [HttpGet]
        public List<ProjectModel> GetByStatus(string status)
        {
            return ProjectService.GetByStatus(status);
        }

        [Route("api/Project/StateProgress/{pId}")]
        [HttpPost]
        public void StateProgress(int pId)
        {
            ProjectService.StateProgress(pId);
        }


        [Route("api/Project/StateCompleted/{pId}")]
        [HttpPost]
        public void StateCompleted(int pId)
        {
            ProjectService.StateCompleted(pId);
        }

        [Route("api/Project/Enrollment/All")]
        [HttpGet]
        public List<EnrollmentModel> GetAllEnrollments()
        {
            return EnrollmentService.GetAll();
        }

        [Route("api/Project/Enroll/Confirm/{eId}")]
        [HttpPost]
        public void Confirm(int eId)
        {
            EnrollmentService.Confirm(eId);
        }


        [Route("api/Project/Enroll/Decline/{eId}")]
        [HttpPost]
        public void Decline(int eId)
        {
            EnrollmentService.Decline(eId);
        }


    }
}
