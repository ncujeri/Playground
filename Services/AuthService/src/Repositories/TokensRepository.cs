using AuthService.Interfaces;
using SimpleJwtProvider.Models;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthService.Repositories
{
    public class TokensRepository : ITokensRepository
    {
        private readonly IRedisProvider _redisProvider;

        public TokensRepository(IRedisProvider redisProvider)
        {
            this._redisProvider = redisProvider;
        }
        public async Task AddTokenAsync(RefreshToken token, string role)
        {
            var db = _redisProvider.GetMultiplexer().GetDatabase();

            var entries = new HashEntry[] {
            new HashEntry("Revoked", token.Revoked),
            new HashEntry("Role", role),
            new HashEntry("Expires", token.ExpirationDate.ToString())};

            await db.HashSetAsync(token.TokenValue, entries);            
        }

        public async Task<HashEntry[]> GetTokenAsync(string tokenValue)
        {
            var db = _redisProvider.GetMultiplexer().GetDatabase();

           return await db.HashGetAllAsync(tokenValue);
            
        }
    }
}
