﻿using AbpTemplate.Response;
using System.Threading.Tasks;

namespace AbpTemplate.Authentication
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// Generate Token
        /// </summary>
        /// <returns></returns>
        Task<ServiceResult<string>> GenerateTokenAsync();

        /// <summary>
        /// Test
        /// </summary>
        /// <returns></returns>
        Task<ServiceResult> Test();
    }
}