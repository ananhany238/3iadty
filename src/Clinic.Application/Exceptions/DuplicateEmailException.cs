
using System.ComponentModel.DataAnnotations;


namespace Clinic.Application.Exceptions
{
    public class DuplicateEmailException : Exception
    {

        public DuplicateEmailException(string email)

             : base("this email already exists in the system") { }


    }
}
