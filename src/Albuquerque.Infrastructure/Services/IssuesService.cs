using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Albuquerque.Core.Data;
using Albuquerque.Core.Entities;
using Albuquerque.Core.Enums;
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
            if (!findByNumRes.IsError)
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

        public async Task<ServiceResult<ICollection<Issue>>> FindInRange(DateTimeOffset? from, DateTimeOffset? to)
        {
            var issues = await _dbContext.Issues.Find(p => 
                p.Deadline >= (from ?? DateTimeOffset.MinValue) 
                && p.Deadline <= (to ?? DateTimeOffset.MaxValue)).ToListAsync();
            return new ServiceResult<ICollection<Issue>>(OperationResultCode.Ok, "", issues);
        }
    }
}