using AutoMapper;
using CF.Data;
using CF.Models;
using CF.Repository.Repositories;
using System;

namespace CF.Repository
{
    public class UnitOfWork
    {
        dbComputerFactoryEntities entities = new dbComputerFactoryEntities();

        private ComputerPartsRepository _ComputerParts;

        public UnitOfWork()
        {
            try
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<tblComputerPart, ComputerPart>()
                    .ForMember(t=>t.PartTypeId, d=>d.MapFrom(s=>s.PartType))
                    .ReverseMap();
                });
            }
            catch (Exception)
            {

            }

        }


        public ComputerPartsRepository ComputerParts
        {
            get
            {
                if (_ComputerParts == null)
                    _ComputerParts = new ComputerPartsRepository(entities);

                return _ComputerParts;
            }
        }
    }
}
