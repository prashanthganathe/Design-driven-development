﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.Entities
{
   public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SiteTypeId { get; set; }
        public int RoleHierarchy { get; set; }
        public virtual SiteType SiteType { get; set; }
        public virtual IEnumerable<UserRole> UserRoles { get; set; }
    }
}
