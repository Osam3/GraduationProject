using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.ViewModels.Category
{
    public class CreateCategoryViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string ShortcutName { get; set; }

        public int? MainCategoryId { get; set; }
    }
}
