using System;
using System.Collections.Generic;

namespace JWT
{
    public partial class TestHomeDb
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string? Email { get; set; }
    }
}
