using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using UdemyProject.Core.Services;
using UdemyProject.Web.DTOs;

namespace UdemyProject.Web.Filters
{
    public class NotFoundFilter:ActionFilterAttribute
    {
        private readonly ICategoryService _categoryService;

        public NotFoundFilter(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int) context.ActionArguments.Values.FirstOrDefault();

            var product = await _categoryService.GetByIdAsync(id);
            if (product != null)
            {
                await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
               
                errorDto.Errors.Add($"id si {id} olan kategori veritabanında bulunamadı");
                context.Result = RedirectToActionResult("Error","Home",errorDto);

            }
        }

        private IActionResult RedirectToActionResult(string v1, string v2, ErrorDto errorDto)
        {
            throw new NotImplementedException();
        }
    }
}
