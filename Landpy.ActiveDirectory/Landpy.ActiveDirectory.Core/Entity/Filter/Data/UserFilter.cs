﻿using System;
using System.Collections.Generic;
using System.Text;
using Landpy.ActiveDirectory.CommonParam;

namespace Landpy.ActiveDirectory.Entity.Filter
{
    class UserFilter : BaseFilter
    {
        public override string BuildFilter()
        {
            return String.Format(FilterStrings.UserFilter);
        }
    }
}
