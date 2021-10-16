using System;

namespace COVID_19PCR.TestManagement.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key)
        : base($"{name} ({key}) is not found")
        {
        }
    }
}
