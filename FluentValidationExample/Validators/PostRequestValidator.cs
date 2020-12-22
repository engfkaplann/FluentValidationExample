using FluentValidation;
using FluentValidationExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationExample.Validators
{
    public class PostRequestValidator : AbstractValidator<PostRequest>
    {
        public PostRequestValidator()
        {
            RuleFor(x => x.email).NotEmpty().Matches(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");//xxxx@xxxx.xxx
            RuleFor(x => x.phoneNumber).NotEmpty().Matches(@"\b\d{12}\b");//90xxxxxxxxx
        }
    }
}
