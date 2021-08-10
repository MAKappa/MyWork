using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Data
{
    public class ActivityUser
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public int ActivityID { get; set; }
        public int UserID { get; set; }
        public Activity Activity { get; set; }
        public User User { get; set; }
    }
}
