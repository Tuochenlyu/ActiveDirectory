﻿using System;
using System.Text;
using Landpy.ActiveDirectory.CommonParam;

namespace Landpy.ActiveDirectory.Filter
{
    class OrFilter : BaseFilter
    {
        public override string BuildFilter()
        {
            StringBuilder childFilters = new StringBuilder();
            foreach (IFilter filter in this.filters)
            {
                childFilters.Append(filter.BuildFilter());
            }
            return String.Format(ExpressionTemplates.Or, childFilters.ToString());
        }
    }
}
