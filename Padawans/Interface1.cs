using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Padawans
{
    interface Interface1
    {
        [Get("/albums/{id}")]
        Task<albu> MetodoA(string id);
        [Get("/posts/{id}")]
        Task<postagem> MetodoP(string id);
        [Get("/todos/{id}")]
        Task<tod> MetodoT(string id);
        Task GetAddressAsync(int id);
        Task GetAddressAsync(Func<string> toString);
    }
}
