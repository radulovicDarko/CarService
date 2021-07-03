using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Shared.Models;
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
        public List<Owner> getAllOwners()
        {
            return this.ownerRepository.GetAllOwners();
        }
        public Owner getOwnerByID(int id) 
        {
            return this.ownerRepository.GetAllOwners().Where(o => o.Id == id).FirstOrDefault();
        }
        public int deleteOwner(Owner owner)
        {
            return this.ownerRepository.DeleteOwner(owner);
        }
        public int insertOwner(Owner owner)
        {
            return this.ownerRepository.InsertOwner(owner);
        }

        public int updateOwner(Owner owner)
        {
            return this.ownerRepository.UpdateOwner(owner);
        }

        public Owner getOwnerByNameAndSurname(String name, String surname)
        {
            return this.ownerRepository.GetAllOwners().Where(o => o.Name.Equals(name) && o.Surname.Equals(surname)).FirstOrDefault();
        }
    }
}
