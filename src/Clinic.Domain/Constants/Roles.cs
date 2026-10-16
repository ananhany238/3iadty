using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Domain.Constants
{
    public static class Roles
    {
        public const string Doctor = "Doctor" ;
        public const string Assistant = "Assistant";
        public const string Patient = "Patient";

        public const string Staff = "Doctor, Assistant";

    }
}
