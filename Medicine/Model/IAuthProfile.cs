﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicine.Model
{
    public interface IAuthProfile
    {
        string GetLogin();
        string GetHashPassword();
        string GetTypeAuth();
    }
}
