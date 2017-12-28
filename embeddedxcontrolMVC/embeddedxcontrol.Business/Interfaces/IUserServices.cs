using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using embeddedxcontrol.Entities;

namespace embeddedxcontrol.Business.Interfaces
{
    public interface IUserServices
    {
        UserEntity GetUserDataById(int userId);
        IEnumerable<UserEntity> GetAllUserData();
        int CreateUserData(UserEntity userEntity);
        bool UpdateUser(int userId, UserEntity userEntity);
        bool DeleteUser(int userId);
    }
}
