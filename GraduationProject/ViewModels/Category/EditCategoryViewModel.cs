using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.ViewModels.Category
{
    public class EditCategoryViewModel
    {
        public int CategoryID { get; set; }

        public string Name { get; set; }

        public string ShortCutName { get; set; }

        public int? MainCategoryId { get; set; }
    }
}
