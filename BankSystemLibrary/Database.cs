using CreditBankSysytem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BankSystemLibrary
{
    public class Database
    {
        private List<User> users;

        public Database()
        {
            users = new List<User>();
            FileStream fs = new FileStream(@"users.json", FileMode.OpenOrCreate);
            using (StreamReader sw = new StreamReader(fs, Encoding.Default))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                users = (List<User>)jsonSerializer.Deserialize(sw, typeof(List<User>));
            }
            if (users == null)
            {
                users = new List<User>();
            }
        }

        public void AddUser(User user)
        {
            users.Add(user);
            JsonSerializer jsonSerializer = new JsonSerializer();
            FileStream fs = new FileStream(@"users.json", FileMode.OpenOrCreate);
            using (StreamWriter streamWriter = new StreamWriter(fs, Encoding.Default))
            {
                using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(jsonWriter, users);
                }
            }
        }

        public User GetUser(long iin)
        {
            foreach (User user in users)
            {
                if (user.IIN == iin)
                {
                    return user;
                }
            }
            return null;
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public bool AuthorityVerify(long iin, string password)
        {
            foreach (User user in users)
            {
                if (user.IIN == iin && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
