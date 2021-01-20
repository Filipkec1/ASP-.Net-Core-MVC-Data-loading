using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Zadatak.Web.Models;

namespace Zadatak.Web.Validators
{
    public class PeopleListValidator : ValidationAttribute
    {


        //public PeopleListValidator()
        //{

        //}

        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    Movie movie = (Movie)validationContext.ObjectInstance;

        //    if (movie.Genre == Genre.Classic && movie.ReleaseDate.Year > _year)
        //    {
        //        return new ValidationResult(GetErrorMessage());
        //    }

        //    return ValidationResult.Success;
        //}
    }
}
