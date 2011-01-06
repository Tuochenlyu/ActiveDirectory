﻿using System.DirectoryServices;
using Landpy.ActiveDirectory.Entity.Attribute;

namespace Landpy.ActiveDirectory.Entity.Object
{
    public abstract class BaseADObject
    {
        protected AttributeProvider attributeProvider;

        protected BaseADObject(SearchResult searchResult)
        {
            this.attributeProvider = new AttributeProvider(searchResult);
        }
    }
}
