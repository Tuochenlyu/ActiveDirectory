﻿using System;
using System.DirectoryServices;
using Landpy.ActiveDirectory.Entity.Attribute;
using Landpy.ActiveDirectory.CommonParam;
using System.Security.Principal;

namespace Landpy.ActiveDirectory.Entity
{
    /// <summary>
    /// The user AD object.
    /// </summary>
    public class User : BaseADObject
    {
        public User(SearchResult searchResult)
            : base(searchResult)
        {
        }

        private string objectSid;
        private Guid objectGUID;
        private string cn;
        private byte[] thumbnailPhoto;

        /// <summary>
        /// The objectSid attribute.
        /// </summary>
        public string ObjectSid
        {
            get
            {
                if (String.IsNullOrEmpty(this.objectSid))
                {
                    BaseAttribute<byte[]> sidAttribute = this.attributeProvider.GetSidAttribute();
                    if (sidAttribute.Value != null)
                    {
                        this.objectSid = new SecurityIdentifier(sidAttribute.Value, 0).ToString();
                    }
                }
                return this.objectSid;
            }
            set
            {
                this.objectSid = value;
            }
        }

        /// <summary>
        /// The objectGUID attribute.
        /// </summary>
        public Guid ObjectGUID
        {
            get
            {
                if (this.objectGUID == Guid.Empty)
                {
                    BaseAttribute<Guid> guidAttribute = this.attributeProvider.GetGuidAttribute();
                    this.objectGUID = guidAttribute.Value;
                }
                return this.objectGUID;
            }
            set
            {
                this.objectGUID = value;
            }
        }

        /// <summary>
        /// The cn attribute.
        /// </summary>
        public string CN
        {
            get
            {
                if (String.IsNullOrEmpty(this.cn))
                {
                    BaseAttribute<string> cnAttribute = this.attributeProvider.GetCNAttribute();
                    this.cn = cnAttribute.Value;
                }
                return this.cn;
            }
            set
            {
                this.cn = value;
            }
        }

        /// <summary>
        /// The thumbnailPhoto attribute.
        /// </summary>
        public byte[] ThumbnailPhoto
        {
            get
            {
                if (this.thumbnailPhoto == null)
                {
                    BaseAttribute<byte[]> thumbnailPhotoAttribute = this.attributeProvider.GetThumbnailPhotoAttribute();
                    this.thumbnailPhoto = thumbnailPhotoAttribute.Value;
                }
                return this.thumbnailPhoto;
            }
            set
            {
                this.thumbnailPhoto = value;
            }
        }
    }
}
