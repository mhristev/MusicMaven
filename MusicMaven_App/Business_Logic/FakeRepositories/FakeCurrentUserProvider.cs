using System;
using Business_Logic.Interfaces;namespace Business_Logic.FakeRepositories
{
	public class FakeCurrentUserProvider : ICurrentUserProvider
	{        private string _userId = String.Empty;        public FakeCurrentUserProvider(string userId)        {            this._userId = userId;        }        public string? GetCurrentUserId()        {            return this._userId;        }    }
}

