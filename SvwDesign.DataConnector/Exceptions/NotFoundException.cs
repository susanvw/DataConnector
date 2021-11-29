using System;

namespace SvwDesign.DataConnector.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string entityname, string value)
            : base($"Record for Entity {entityname} with value {value} could not be found.")
        {

        }
    }
}
