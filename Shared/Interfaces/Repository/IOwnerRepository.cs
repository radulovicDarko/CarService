using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IOwnerRepository
    {
        List<Owner> GetAllOwners();
        int InsertOwner(Owner owner);
        int UpdateOwner(Owner owner);
        int DeleteOwner(Owner owner);
    }
}
