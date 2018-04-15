using CF.Models;
using CF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Managers
{
    public class ComputerManager
    {
        private UnitOfWork _UnitOfWork = new UnitOfWork();

        public IEnumerable<ComputerPart> GetComputerParts(int id)
        {             
               return _UnitOfWork.ComputerParts.Get(id);
        }

        public void AddComputerPart(string PartName, int PartTypeId, double price)
        {
            var cPart = new ComputerPart
            {
                PartName = PartName,
                PartTypeId = PartTypeId,
                Price = price
            };

            _UnitOfWork.ComputerParts.Add(cPart);
        }
    }
}
