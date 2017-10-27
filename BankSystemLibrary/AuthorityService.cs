using CreditBankSysytem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLibrary
{
    public class AuthorityService : Service
    {
        public User AuthorityVerify(long iin, string password)
        {
            foreach (var user in Database.GetUsers())
            {
                if (user.IIN == iin && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
