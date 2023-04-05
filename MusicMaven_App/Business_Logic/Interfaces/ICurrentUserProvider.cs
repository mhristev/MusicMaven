using System;
namespace Business_Logic.Interfaces
{
	public interface ICurrentUserProvider
	{
        string? GetCurrentUserId();
    }
}

