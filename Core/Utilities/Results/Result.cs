using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //get komutu Readonly dir, sadece constructor içerisinde set edilebilir.
        //                                       //bu class'daki tek parametreli constructor'ı çalıştır
        public Result(bool success, string message):this(success)
        {
            this.Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
