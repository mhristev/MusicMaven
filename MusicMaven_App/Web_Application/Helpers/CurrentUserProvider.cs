using System;
using Business_Logic.Interfaces;    

namespace Business_Logic.Services
{
	public class CurrentUserProvider : ICurrentUserProvider
	{
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string? GetCurrentUserId()
        {
            return _httpContextAccessor.HttpContext?.User?.FindFirst("Id")?.Value;
        }
    }
}

