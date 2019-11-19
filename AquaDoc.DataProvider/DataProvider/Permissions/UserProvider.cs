using AquaDoc.DataEntities;
using AquaDoc.DataInterface;

namespace AquaDoc.DataProvider
{
    public class UserProvider : Repository<User>, IUser
    {
    }
}
