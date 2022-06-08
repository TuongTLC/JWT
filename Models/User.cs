using System;
using System.Collections.Generic;

namespace JWT
{
    public partial class User
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public bool Status { get; set; }
        public int Id { get; set; }
    }
}
