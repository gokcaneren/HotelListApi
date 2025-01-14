﻿using HotelListing.API.Models.User;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<IEnumerable<IdentityError>> RegisterAdmin(ApiUserDto userDto);
        Task<AuthResponsDto> Login(LoginDto loginDto);
    }
}
