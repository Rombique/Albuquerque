using System;

using System.Collections.Generic;
using System.Threading.Tasks;
using Albuquerque.Core.Entities;
using Albuquerque.Core.Helpers;
using Albuquerque.Core.Models;

namespace Albuquerque.Infrastructure.Services
{
    public interface IIssuesService
    {
        public Task<ServiceResult<Issue>> Create(NewIssueModel model);
        public Task<ServiceResult<ICollection<Issue>>> FindByNumber(string number);
        public Task<ServiceResult<ICollection<Issue>>> FindInRange(DateTime? from, DateTime? to);
    }
}