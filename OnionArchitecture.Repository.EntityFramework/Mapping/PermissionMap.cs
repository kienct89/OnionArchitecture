﻿using OnionArchitecture.Core.Models.Common;

namespace OnionArchitecture.Repository.EntityFramework.Mapping
{
    public class PermissionMap : EntityBaseMap<Permission>
    {
        public PermissionMap()
        {
            HasRequired(c => c.Resource).WithMany(c => c.Permissions).HasForeignKey(c => c.ResourceId);
            HasOptional(c => c.User).WithMany(c => c.Permissions).HasForeignKey(c => c.UserId);
            HasOptional(c => c.Role).WithMany(c => c.Permissions).HasForeignKey(c => c.RoleId);
        }
    }
}
