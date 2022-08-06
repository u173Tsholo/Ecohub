using EcoHub.Data;
using EcoHub.Models;

namespace EcoHub.Services
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private EcoHubContext _db;

        public UserRepository(EcoHubContext db) : base(db)
        {
            _db = db;
        }

        public void Update(User obj)
        {
            //var objFromDb = _db.Users.FirstOrDefault(u => u.Id == obj.Id);
            //if (objFromDb != null)
            //{
            //    objFromDb. = obj.FirstName;
            //    objFromDb.Surname = obj.Surname;
            //    objFromDb.PhoneNumber = obj.PhoneNumber;
            //    objFromDb.StreetAddress = obj.StreetAddress;
            //    objFromDb.CountryId = obj.CountryId;
            //    objFromDb.ProvinceId = obj.ProvinceId;
            //    objFromDb.CityId = obj.CityId;
            //    objFromDb.SuburbId = obj.SuburbId;
            //    objFromDb.EmailConfirmed = obj.EmailConfirmed;


            }
    }
}
