﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class02.Exercise.Interfaces
{
    public interface ITeacher : IUser
    {
        string Subject { get; set; }
    }
}
