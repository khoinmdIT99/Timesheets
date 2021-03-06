﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Timesheets.Areas.Identity.Data;
using Timesheets.Models;

namespace Timesheets.ViewModels
{
    public class DepartmentDetailsViewModel
    {
        public Department Department { get; set; }
        public ApplicationUser DepartmentHead { get; set; }
        public IEnumerable<Project> OwnedProjects { get; set; }
        public IEnumerable<Project> RelatedProjects { get; set; }

    }
}
