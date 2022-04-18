﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace Contact.Management.Appliaction.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<String> Errors { get; set; } = new List<string>();


        public ValidationException(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }
        }
    }
}
