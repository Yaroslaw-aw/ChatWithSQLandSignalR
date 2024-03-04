﻿using Chat.BLL.Services.Contracts;
using Chat.Common.Entities;
using Chat.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<bool> CheckIfExistsAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task RegistrateAsync(string name, Guid userId)
        {
            User user = new User
            {
                Id = userId,
                Name = name,
            };
        }
    }
}
