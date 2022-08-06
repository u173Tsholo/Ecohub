using EcoHub.Data;
using EcoHub.Models;

namespace EcoHub.Services
{
    public class UserManagementService : IUserManagementService
    {
        private readonly EcoHubContext _db;
        public UserManagementService(EcoHubContext db)
        {
            _db = db;
        }
        public void CreateUser(User user)
        {
            if(user != null)
            {
                _db.Users.Add(user);  
                _db.SaveChanges();
            }
        }

        //public async Task<string> UpdateUser(User user)
        //{
        //    User exists = await _db.Users.FindAsync(user);
        //    if (exists != null)
        //    {
        //        exists.Name = user.Name;
        //        exists.Price = user.Price;
        //        exists.Approved = user.Approved;
        //        exists.Flagged = user.Flagged;
        //    }
        //    return "Updated";
        //}

    }
}
