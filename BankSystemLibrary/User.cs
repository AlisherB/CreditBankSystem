﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditBankSysytem
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public long IIN { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public long Telephone { get; set; }

        public Branch BranchName;

    }
}
