using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OwnerBusiness : IOwnerBusiness
    {
        private readonly IOwnerRepository ownerRepository;

        public OwnerBusiness(IOwnerRepository _ownerRepository)
        {
            this.ownerRepository = _ownerRepository;
        }
    }
}
