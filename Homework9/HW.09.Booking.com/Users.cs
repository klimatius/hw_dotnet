using System.Collections;


namespace HW._09.Booking.com
{
    internal class Users
    {
        string username;
        string password;
        string firstName;
        string lastName;
        string email;

        /// <summary>
        ///  
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        internal Users(string username, string password, string firstName, string lastName, string email)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userList"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        internal static bool Login(ArrayList userList, string username, string password)
        {
            foreach (var item in userList)
            {
                if((item as Users).username.Equals(username))
                {
                    if ((item as Users).password.Equals(password))
                        return true;
                }    
            }

            return false;
        }
    }
}
