﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalProject.Models.ViewModels
{
    public class PatientList
    {
        public IEnumerable<PatientDto> Patients { get; set; }
    }
}