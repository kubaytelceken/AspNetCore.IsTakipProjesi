using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YSKProje.ToDo.Web.Areas.Admin.Models
{
    public class AppUserListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
    }
}
