﻿using System;
using System.Collections.Generic;
using System.Text;
using Landpy.ActiveDirectory.Core;
using Landpy.ActiveDirectory.CommonParam;

namespace Landpy.ActiveDirectory.Entity.Filter
{
    class OrExpressionDecorator : BaseExpressionDecorator
    {
        public OrExpressionDecorator(IFilter filter)
            : base(filter)
        {
        }

        public override string BuildFilter()
        {
            return String.Format(ExpressionTemplates.Or, filter.BuildFilter());
        }
    }
}
