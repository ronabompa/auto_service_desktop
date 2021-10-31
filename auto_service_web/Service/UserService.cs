using ServiceAutoFINAL.Entities;
using System.Text;
using System.Security.Cryptography;
using ServiceAutoFINAL.Repositories;

namespace ServiceAutoFINAL.Service
{
    public interface IUserService
    {
        public User getUser(string username, string password);
        public string encyptPassword(string password);
        public bool validateUser(string passwordDB, string password);
        public bool createUser(string username, string password, string name);
    }

    public class UserService : IUserService
    {
        
        IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string encyptPassword(string password)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(password));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public bool validateUser(string passwordDB, string password)
        {
            if(passwordDB.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        /**
        *  fetches User from db
        */
        public User getUser(string username, string password)
        {
            User dbUser = _unitOfWork.User.Get(username);
            if(dbUser != null && validateUser(dbUser.password, encyptPassword(password)))
            {
                return dbUser;
            }
            else
            {
                return null;
            }
        }

        /**
         *  inserts an User in db
         *  returns true the User was inserted
         */
        public bool createUser(string username, string password, string name)
        {
            User user = new User(username, encyptPassword(password), name); 
            _unitOfWork.User.Add(user);

            User dbUser = _unitOfWork.User.Get(username);  //verificam daca s-a creat
            if (dbUser != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
