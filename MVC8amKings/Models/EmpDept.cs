﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC8amKings.Models
{
    public class EmpDept
    {
        public List<EmployeeModel> emp { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }
}