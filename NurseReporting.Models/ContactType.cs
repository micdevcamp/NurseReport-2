﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurseReporting.Models
{
    public class ContactType : Entity
    {
        public string Label { get; set; }

        public bool IsResponsibleForChild { get; set; }
    }
}
