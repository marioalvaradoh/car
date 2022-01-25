using COMMON.DomainModels;
using DATA.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Context
{
    public partial class PracticeContext : IPracticeContextUnitOfWork
    {
        public async Task<int> SaveChangesAsync() => await base.SaveChangesAsync();
    }
}
