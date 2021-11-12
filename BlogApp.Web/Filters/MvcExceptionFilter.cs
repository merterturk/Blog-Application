using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Shared.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BlogApp.Web.Filters
{
    public class MvcExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _environment;
        private readonly IModelMetadataProvider _metadataProvider;
        private readonly ILogger<MvcExceptionFilter> _logger;

        public MvcExceptionFilter(IModelMetadataProvider metadataProvider, IHostEnvironment environment, ILogger<MvcExceptionFilter> logger)
        {
            _metadataProvider = metadataProvider;
            _environment = environment;
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            if (_environment.IsDevelopment())
            {
                context.ExceptionHandled = true;
                var mvcErrorModel = new MvcErrorModel();
                ViewResult result;
                switch (context.Exception)
                {
                    case SqlNullValueException:
                        mvcErrorModel.Message =
                            "Üzgünüz, işleminiz sırasında beklenmedik bi veritabanı hatası oluştu. Sorunu en kısa sürede çözeceğiz";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult() {ViewName = "Error"};
                        result.StatusCode = 500;
                        _logger.LogError(context.Exception,context.Exception.Message);
                        break;
                    case NullReferenceException:
                        mvcErrorModel.Message =
                            "Üzgünüz, işleminiz sırasında beklenmedik bi null veriye rastlandı. Sorunu en kısa sürede çözeceğiz";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult() { ViewName = "Error" };
                        result.StatusCode = 403;
                        _logger.LogError(context.Exception,"Bu Benim log hata mesajım!");
                        break;
                    default:
                        mvcErrorModel.Message =
                            "Üzgünüz, işleminiz sırasında beklenmedik bir hata oluştu. Sorunu en kısa sürede çözeceğiz";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult() { ViewName = "Error" };
                        result.StatusCode = 500;
                        _logger.LogError(context.Exception, context.Exception.Message);
                        break;
                }
                
                result.ViewData = new ViewDataDictionary(_metadataProvider, context.ModelState);
                result.ViewData.Add("MvcErrorModel",mvcErrorModel);
                context.Result = result;
            }
        }
    }
}
