using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtExchange.Application.Contracts.Entity
{
    public interface IEntity
    {
        long Id { get; set; }
    }
}
