﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Albuquerque.Core.Data;
using Albuquerque.Core.Entities;
using Albuquerque.Core.Enums;
using Albuquerque.Core.Extensions;
using Albuquerque.Core.Helpers;
using Albuquerque.Core.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Omu.ValueInjecter;

namespace Albuquerque.Infrastructure.Services
{
    public class IssuesService : IIssuesService
    {
        readonly IMongoContext _dbContext;

        public IssuesService(IMongoContext context) =>
            _dbContext = context;
        
        public async Task<ServiceResult<Issue>> Create(NewIssueModel model)
        {
            var findByNumRes = await FindByNumber(model.Number);
            if (findByNumRes.Value.Any())
                return new ServiceResult<Issue>(OperationResultCode.UnprocessableEntity,
                    $"Заявка с номером {model.Number} уже существует");

            var issue = new Issue();
            issue.InjectFrom(model);
            await _dbContext.Issues.InsertOneAsync(issue);
            
            return new ServiceResult<Issue>(OperationResultCode.Ok, "", issue);
        }

        public async Task<ServiceResult<ICollection<Issue>>> FindByNumber(string number)
        {
            var filter = Builders<Issue>.Filter.Regex("Number", new BsonRegularExpression($"^{number}.*", "i"));
            var issues = await _dbContext.Issues.Find(filter).ToListAsync();
            return new ServiceResult<ICollection<Issue>>(OperationResultCode.Ok, "", issues);
        }

        public async Task<ServiceResult<ICollection<Issue>>> FindInRange(DateTime? from, DateTime? to, bool includeIsDone = false)
        {
            Expression<Func<Issue, bool>> filter = p =>
                p.Deadline >= (from ?? DateTime.MinValue)
                && p.Deadline <= (to ?? DateTime.MaxValue);
            if (!includeIsDone) // FIXME: 
                filter = p =>
                    p.Deadline >= (from ?? DateTime.MinValue)
                    && p.Deadline <= (to ?? DateTime.MaxValue)
                    && p.IsDone == includeIsDone;

            var issues = await _dbContext.Issues.Find(filter).ToListAsync();
            return new ServiceResult<ICollection<Issue>>(OperationResultCode.Ok, "", issues);
        }
    }
}