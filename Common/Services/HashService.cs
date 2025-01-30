using System;
using Behnammby.Common.Exceptions;
using HashidsNet;
using Microsoft.Extensions.Configuration;

namespace Behnammby.Common.Services
{
    public class HashService : IHashService
    {
        private readonly Hashids _hashIds;

        public HashService(IConfiguration configuration)
        {
            var config = configuration.GetSection("HashService");

            var salt = config["Salt"];
            var minLength = config.GetValue<int>("MinLength");

            _hashIds = new Hashids(salt, minLength);
        }

        public int Decode(string hash)
        {
            try
            {
                var ids = _hashIds.Decode(hash);
                if (ids.Length > 0)
                {
                    return ids[0];
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new HashInvalidException($"Hash string '{hash}' is invalid.");
            }

            return default;
        }

        public string Encode(int id) => _hashIds.Encode(id);
    }
}