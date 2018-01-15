using embeddedxcontrol.Business.Interfaces;
using embeddedxcontrol.Entities;
using embeddedxcontrol.Repo;
using embeddedxcontrol.Repo.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embeddedxcontrol.Business.Services
{
    public class UserServices : IUserServices
    {

        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor
        /// </summary>
        public UserServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserEntity GetUserDataById(string userId)
        {
            AspNetUser ru = _unitOfWork.UserRepository.GetByID(userId);
            UserEntity user = new UserEntity();

            //Only return First Last Name, Username
            user.FirstName = ru.FirstName;
            user.LastName = ru.LastName;
            user.UserName = ru.UserName;

            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserEntity> GetAllUserData()
        {
            List<UserEntity> listofusers = new List<UserEntity>();

            return listofusers;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        public int CreateUserData(UserEntity userEntity)
        {
            return 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEntity"></param>
        /// <returns></returns>
        public bool UpdateUser(int userId, UserEntity userEntity)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool DeleteUser(int userId)
        {
            return true;
        }
    }
}
