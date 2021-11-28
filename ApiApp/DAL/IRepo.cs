using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepo<T>
    {
        void Add(T e);
        void Edit(T e);
        void Delete(T e);
        List<T> Get();
    }


    public interface IRepo<T, ID, Status>
    {
        void Add(T e);
        void Edit(T e);
        void StateProgress(ID pId);
        void StateCompleted(ID pId);
        void Delete(T e);
        List<T> GetAll();
        T GetById(ID id);
        List<T> GetByStatus(Status status);
        List<T> GetByMIdStatus(ID id, Status status);
        List<T> GetByMIdApplied(ID id);
    }


    public interface IRepo<T, ID1, ID2, Extra>
    {
        List<T> GetAll();
        void Add(ID1 pId, ID2 mId);
        void Confirm(ID1 eId);
        void Decline(ID1 eId);
    }


}
