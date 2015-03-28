﻿using OnionArchitecture.Core.Models.Common;

namespace OnionArchitecture.Repository.EntityFramework.Mapping
{
    public class UserMap : EntityBaseMap<User>
    {
        public UserMap()
        {
            HasMany(c => c.Roles).WithMany();
            HasMany(c => c.Permissions).WithOptional().HasForeignKey(c => c.UserId);
        }
    }
}