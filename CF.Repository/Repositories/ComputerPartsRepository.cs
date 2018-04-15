using AutoMapper;
using CF.Data;
using CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CF.Repository.Repositories
{
    public class ComputerPartsRepository
    {
        public dbComputerFactoryEntities Entities { get; }

        public ComputerPartsRepository(dbComputerFactoryEntities entities)
        {
            Entities = entities;
        }

      

        public IEnumerable<ComputerPart> Get(int id)
        {
            var raw = Entities.tblComputerParts.ToList();
            return Mapper.Map<IEnumerable<ComputerPart>>(raw);

        }

        public void Add(ComputerPart Updatedentity)
        {
            var newData = Mapper.Map<tblComputerPart>(Updatedentity);

            Entities.tblComputerParts.Add(newData);
            Entities.SaveChanges();
        }

        public void Update(ComputerPart entity)
        {

            var data = Entities.tblComputerParts.FirstOrDefault(d => d.id == entity.id);

            if (data == null)
                return;

            data.Price = entity.Price;
            data.PartName = entity.PartName;
            Entities.SaveChanges();
        }
    }
}
