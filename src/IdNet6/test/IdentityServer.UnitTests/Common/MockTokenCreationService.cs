﻿using IdNet6.Models;
using IdNet6.Services;
using System.Threading.Tasks;

namespace IdentityServer.UnitTests.Common
{
    class MockTokenCreationService : ITokenCreationService
    {
        public string Token { get; set; }

        public Task<string> CreateTokenAsync(Token token)
        {
            return Task.FromResult(Token);
        }
    }
}
