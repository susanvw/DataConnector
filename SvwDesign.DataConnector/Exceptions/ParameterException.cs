using System;

namespace SvwDesign.DataConnector.Exceptions
{
    public class ParameterException : Exception
    {
        public ParameterException(string message) : base(message)
        {
        }
    }
}
