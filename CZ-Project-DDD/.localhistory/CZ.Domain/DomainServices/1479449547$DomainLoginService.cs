﻿using CZ.Domain.Entities;
using CZ.Domain.Interfaces;
using CZ.Domain.Interfaces.IDomainServices;
using CZ.Domain.Interfaces.IUnitOfWork;
using CZ.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Domain.DomainServices
{
    public class DomainLoginService : DomainServiceBase<User>, IDomainLoginService
    {

        private readonly ILoginRepository _loginRepository;
        public DomainLoginService(ILoginRepository loginRepository, IUnitOfWork uow) : base(uow)
        {
            _loginRepository = loginRepository;
        }

        public User ValidateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
