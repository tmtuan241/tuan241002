using Infrastructure.Entities;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public interface IGiayDepService
    {
        IQueryable<GiayDep> GetGiayDeps();
        GiayDep GetGiayDep(int id);
        void InsertGiayDep(GiayDep giayDep);
        void UpdateGiayDep(GiayDep giayDep);
        void DeleteGiayDep(GiayDep giayDep);
    }

    public class GiayDepService : IGiayDepService
    {
        private IGiayDepRepository giayDepRepository;

        public GiayDepService(IGiayDepRepository giayDepRepository)
        {
            this.giayDepRepository = giayDepRepository;
        }

        public IQueryable<GiayDep> GetGiayDeps()
        {
            return giayDepRepository.GetAll();
        }

        public GiayDep GetGiayDep(int id)
        {
            return giayDepRepository.GetById(id);
        }

        public void InsertGiayDep(GiayDep giayDep)
        {
            giayDepRepository.Insert(giayDep);
        }

        public void UpdateGiayDep(GiayDep giayDep)
        {
            giayDepRepository.Update(giayDep);
        }

        public void DeleteGiayDep(GiayDep giayDep)
        {
            giayDepRepository.Delete(giayDep);
        }
    }
}
