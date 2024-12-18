using OrisonMIS.Shared.Dtos;
using OrisonMIS.Shared.Entities.API;
using Syncfusion.XlsIO.Parser.Biff_Records.Formula;
using System;
using System.Net;

namespace OrisonMIS.Server.Exceptions
{
    public class ExceptionHandlingMiddleware
    {
        public readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
                _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        public async Task HandleExceptionAsync(HttpContext context, Exception exception) {

            HttpStatusCode status;
            string message;
            string? details;

            switch (exception)
            {
                case StoredProcedureRelatedException:
                    status = HttpStatusCode.InternalServerError;
                    message = exception.Message;
                    details = exception.InnerException?.Message; 
                    break;

                default:
                    status = HttpStatusCode.InternalServerError;
                    message = "Some error occurred.Contact the administrator, please.";
                    details = exception.Message; 
                    break;
            }

            context.Response.StatusCode = (int)status;

            var
                 response = new ErrorResponseDto
                 {
                     StatusCode = (int)status,
                     Message = message,
                     Details = details
                 };


            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(response);
        }

    }
}
