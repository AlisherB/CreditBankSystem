using CreditBankSysytem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLibrary
{
    public class ServiceUsers
    {
        Database database;
        User currentUser;

        public ServiceUsers()
        {
            database = new Database();
            currentUser = new User();
        }

        public void AddUser(User user)
        {
            database.AddUser(user);
        }

        public bool AuthorityVerify(long iin, string password)
        {
            if (database.AuthorityVerify(iin, password))
            {
                return true;
            }
            return false;
        }

        public void GetUser(long iin)
        {
            currentUser = database.GetUser(iin);
        }

        public User CurrentUser()
        {
            return currentUser;
        }
    }
}
