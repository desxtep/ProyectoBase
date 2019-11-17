using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Models
{
    class Response
    {
        public bool IsSuccess {
            get;
            set;
        }
        public string Menssage
        {
            get;
            set;
        }
        public object Result
        {
            get;
            set;
        }
        public string Message { get; internal set; }
    }
}
