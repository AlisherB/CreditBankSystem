using CreditBankSysytem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemLibrary
{
    public class AuthorityService
    {
        private string hashedIIN;
        private string hashedPassword;
        private List<User> users;
        public User AuthorityVerify(string iin, string password)
        {
            foreach (var user in users)
            {
                if (iin == user.IIN && password, user.Password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
