﻿using System;
using Business_Logic.Models;
{
	public interface IUserService
	{
        void CreateUser(User user);

        void UpdateUser(User user);

        void DeleteUser(User user);
    }
}
