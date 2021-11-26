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
    public class ProjectService
    {
        public static void Add(ProjectModel p)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ProjectModel, Project>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Project>(p);
            DataAccessFactory.ProjectDataAcess().Add(data);
        }

        public static List<ProjectModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Project, ProjectModel>();
                //c.CreateMap<Department, DepartmentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ProjectDataAcess();
            var data = mapper.Map<List<ProjectModel>>(da.GetAll());
            return data;
        }


        public static ProjectModel GetById(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Project, ProjectModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ProjectDataAcess();
            var data = mapper.Map<ProjectModel>(da.GetById(id));
            return data;
        }



        public static List<ProjectModel> GetByStatus(string status)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Project, ProjectModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ProjectDataAcess();
            var data = mapper.Map<List<ProjectModel>>(da.GetByStatus(status));
            return data;
        }


        public static List<ProjectModel> GetByMIdApplied(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Project, ProjectModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ProjectDataAcess();
            var data = mapper.Map<List<ProjectModel>>(da.GetByMIdApplied(id));
            return data;
        }


        public static List<ProjectModel> GetByMIdStatus(int id, string status)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Project, ProjectModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ProjectDataAcess();
            var data = mapper.Map<List<ProjectModel>>(da.GetByMIdStatus(id, status));
            return data;
        }


        public static void StateProgress(int pId)
        {
            DataAccessFactory.ProjectDataAcess().StateProgress(pId);
        }

        public static void StateCompleted(int pId)
        {
            DataAccessFactory.ProjectDataAcess().StateCompleted(pId);
        }
    }
}
