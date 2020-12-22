using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DI
{
    public class BusinessLogicLayers
    {
        private readonly IRepositoryLayer DAL;

        public BusinessLogicLayers(IRepositoryLayer repositoryLayer)
        {
            DAL = repositoryLayer;
        }

        public void Save(Object details)
        {
            DAL.Save(details);
        }
    }

    public interface IRepositoryLayer
    {
        void Save(Object details);
    }

    public class DataAccessLayers : IRepositoryLayer
    {
        public void Save(Object details)
        {
            //perform save
        }
    }
}
