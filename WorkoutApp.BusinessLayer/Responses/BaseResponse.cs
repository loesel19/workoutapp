using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp.BusinessLayer.Responses
{
    public class BaseResponse<T>
    {
        public T? Data { get; set; }
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public int Status { get; set; }

        public BaseResponse<T> Error(T _data, int? _status, string? _message)
        {
            return new BaseResponse<T> 
            { 
                IsSuccess = false,
                Data = _data, 
                Status = _status ?? 500, 
                Message = _message ?? "An error has occurred on the server."
            };
        }

        public BaseResponse<T> Success(T _data, int? _status, string? _message)
        {
            return new BaseResponse<T>
            {
                IsSuccess = true,
                Data = _data,
                Status = _status ?? 200,
                Message = _message ?? "Successfully retrieved item from server."
            };
        }

    }
}
