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
            RuleFor(x => x.email)
                .NotEmpty().WithMessage("Email address is required")
                .EmailAddress().WithMessage("Email address is not valid")
                .Length(1,20).WithMessage("Length must be maximum 20")
                .Matches(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$").WithMessage("Invalid email format");

            RuleFor(x => x.phoneNumber).NotEmpty().Matches(@"\b\d{12}\b");//90xxxxxxxxx

            RuleFor(x => x.password).NotEmpty().Matches(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,50}$").WithMessage("Password required minumum eight characters, at least one letter and one number");
        }
    }
}
