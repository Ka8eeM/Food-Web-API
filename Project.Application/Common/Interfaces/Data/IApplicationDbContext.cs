using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Common.Interfaces.Data;

public interface IApplicationDbContext
{
    // DBset here

    DatabaseFacade Database { get; }
}
