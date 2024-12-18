using OrisonMIS.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.API
{
    public class ApiResponseDto<T> 
    {
        public bool Success { get; set; } = true;
        public T? Data { get; set; }
        public ErrorResponseDto Error { get; set; }

        [JsonConstructor]
        public ApiResponseDto(bool Success,T Data, ErrorResponseDto Error) { 
            this.Success = Success;
            this.Data = Data;
            this.Error = Error;
        }
        public ApiResponseDto(T Data, ErrorResponseDto Error)
        {
            this.Data = Data;
            this.Error = Error;
        }
        public ApiResponseDto(T Data)
        {
            this.Data = Data;
        }
    }
}
