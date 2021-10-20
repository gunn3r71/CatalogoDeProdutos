using Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalogo.Domain.Services
{
    public interface IService<T> where T : EntityBase
    {

    }
}
