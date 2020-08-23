﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Models;

namespace Timesheets.Areas.Identity.Data
{
    // Check: https://docs.microsoft.com/en-us/aspnet/core/security/authentication/add-user-data?view=aspnetcore-3.0&tabs=visual-studio
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }
        [PersonalData]
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        [PersonalData]
        public double ManHourCost { get; set; }

        [PersonalData]
        public long? DepartmentId { get; set; }
        public Department? Department { get; set; }

        [PersonalData]
        public string? ManagerId { get; set; }
        public ApplicationUser Manager { get; set; }

        public ICollection<TimesheetEntry> TimesheetEntries { get; set; }

        public Department? HeadingDepartment { get; set; }
    }
}
