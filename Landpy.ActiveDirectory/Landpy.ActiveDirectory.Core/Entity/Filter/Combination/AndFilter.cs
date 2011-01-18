﻿using System;
using System.Collections.Generic;
using System.Text;
using Landpy.ActiveDirectory.Core;
using Landpy.ActiveDirectory.CommonParam;

namespace Landpy.ActiveDirectory.Entity.Filter
{
    class AndFilter : BaseFilter
    {
        public override string BuildFilter()
        {
            StringBuilder childFilters = new StringBuilder();
            foreach (IFilter filter in this.filters)
            {
                childFilters.Append(filter.BuildFilter());
            }
            return String.Format(ExpressionTemplates.And, childFilters.ToString());
        }
    }
}
