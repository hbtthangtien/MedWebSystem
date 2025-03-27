using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.ExceptionCustom
{
    public class RegisterException : Exception
    {
        public RegisterException()
        {
        }
        public RegisterException(IEnumerable<IdentityError> errors)
            :base(string.Join(";",errors.Select(e => $"{e.Description}")))
        {
            
        }
        public RegisterException(string? message) : base(message)
        {
        }

        public RegisterException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RegisterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
