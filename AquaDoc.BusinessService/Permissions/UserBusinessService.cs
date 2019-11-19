using AquaDoc.DataEntities;
using AquaDoc.Framework;

namespace AquaDoc.BusinessService
{
    public class UserBusinessService : DbServiceBase<User>
    {
        public User Login(string eamil, string password)
        {
            User user = FirstOrDefault(new DirectSpecification<User>(t => t.Email == eamil && t.Password == password & t.IsEnabled));
            return user;
        }
    }
}
