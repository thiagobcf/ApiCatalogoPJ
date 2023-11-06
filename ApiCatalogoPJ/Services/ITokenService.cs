using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCatalogoPJ.Models;

namespace ApiCatalogoPJ.Services
{
    public interface ITokenService
    {
        string GerarToken(string key, string issuer,string audience, UserModel user);
    }
}