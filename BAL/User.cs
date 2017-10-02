using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibryManagement.BAL
{
    class User
    {
        private static int userSize;
        private int userId;
        private String userName;
        private String password;



        public void User(int id)
        {
            this.userId = id;
            userSize += 1;
        }

        public void RemoveUser(int id) //return type boolean
        {
            //TODO: Call the Remove procedure and return the value is true or false 
        }

        public void Login(String uId, String pwd) // return type boolean
        {
            //TODO: Call Login Procedure and return the value is login sucess or false
        }

        public void Login2(String uId, String pwd) // return type boolean
        {
            //TODO: Call Login Procedure and return the value is login sucess or false
        }

       
    }
}
