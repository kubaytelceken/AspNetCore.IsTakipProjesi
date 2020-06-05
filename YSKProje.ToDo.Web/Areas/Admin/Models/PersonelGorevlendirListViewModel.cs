using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web.Areas.Admin.Models
{
    public class PersonelGorevlendirListViewModel
    {
        public AppUserListViewModel AppUser { get; set; }
        public GorevListViewModel Gorev { get; set; }
    }
}
