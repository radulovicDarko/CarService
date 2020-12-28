using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IOwnerBusiness
    {
        List<Owner> getAllOwners();
        int insertOwner(Owner owner);
        int updateOwner(Owner owner);
        int deleteOwner(Owner owner);
        Owner getOwnerByID(int id);
        Owner getOwnerByNameAndSurname(String name, String surname);
    }
}
