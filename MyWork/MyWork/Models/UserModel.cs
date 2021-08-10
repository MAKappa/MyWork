using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyWork.Models
{
    public class UserModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public String Username { get; set; }
        public String Surname { get; set; }
        public DateTime UserEntryDate { get; set; }
        public ICollection<ActivityUserModel> ActivityUsers { get; set; }
    }
}
