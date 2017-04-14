﻿using AspNetIdentity.WebApi.Infrastructure;
using CZ.Domain.Entities;
using CZ.Domain.Interfaces.IRepositories;
using CZ.Infra.Data.Context;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System.Net.Http;
using Microsoft.Owin;
namespace CZ.Infra.Data.Repositories
{


    public class LoginRepository : RepositoryBase<User>, ILoginRepository
    {
        public LoginRepository(DomainContext context) : base(context)
        {
        }
        public User ValidateUser(User user)
        {
            var _userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(new DomainContext()));
            var userM = _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            ApplicationUser Appusr =  userM.FindAsync(user.UserName, user.Password).Result;
            User DomainUser = new User {  UserName = Appusr.UserName };
            return DomainUser;
        }

    }
}