using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Albuquerque.Core.Entities;
using Albuquerque.Core.Helpers;
using Albuquerque.Core.Models;
using Albuquerque.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Albuquerque.Web.Controllers
{
    [Route("api/[controller]")]
    public class IssuesController : ControllerBase
    {
        private readonly IIssuesService _issuesService;

        public IssuesController(IIssuesService issuesService) =>
            _issuesService = issuesService;

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] NewIssueModel model)
        {
            if (!ModelState.IsValid)
                return CreateBadRequest(ModelState);

            var result = await _issuesService.Create(model);
            if (result.IsError)
                return CreateBadRequest(ModelState, result.Message);

            return new OkObjectResult(result.Value);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll(DateTime? from, DateTime? to, bool includeIsDone)
        {
            var res = await _issuesService.FindInRange(from, to, includeIsDone);
            return new OkObjectResult(res.Value);
        }
        
        [HttpGet(nameof(Find))]
        public async Task<IActionResult> Find([Required] string number)
        {
            if (string.IsNullOrEmpty(number))
                return CreateBadRequest(ModelState, "Номер заявки пустой");
            var result = await _issuesService.FindByNumber(number);
            if (result.IsError)
                return NotFound();

            return new OkObjectResult(result.Value);
        }
        
        private object GetModelStateErrors(ModelStateDictionary modelState) =>
            modelState.Values
                .SelectMany(p => p.Errors)
                .Select(p => p.ErrorMessage)
                .ToList();

        private BadRequestObjectResult CreateBadRequest(ModelStateDictionary modelState)
        {
            var errors = GetModelStateErrors(modelState);
            return new BadRequestObjectResult(errors);
        }
        
        private BadRequestObjectResult CreateBadRequest(ModelStateDictionary modelState, string error)
        {
            AddErrorToModelState("errors", error, modelState);
            return CreateBadRequest(modelState);
        }
        
        private ModelStateDictionary AddErrorToModelState(string code, string description, ModelStateDictionary modelState)
        {
            modelState.TryAddModelError(code, description);
            return modelState;
        }
    }
}