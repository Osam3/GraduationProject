using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.ViewModels.Measurements
{
    public class CreateMeasurementViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
