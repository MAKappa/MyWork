using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Models
{
    public class ActivityUserModel
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public int ActivityID { get; set; }
        public int UserID { get; set; }
        public ActivityModel Activity { get; set; }
        public UserModel User { get; set; }
    }
}
