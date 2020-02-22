using System;
using System.Collections.Generic;

namespace Routine.Api.Services
{
    public class PropertyMappingValue
    {
        public IEnumerable<string> DestinationProperties { get; set; }

        public bool Revert { get; set; }

        public PropertyMappingValue(IEnumerable<string> destinationProperties, bool revert = false)
        {
            DestinationProperties = destinationProperties 
                                    ?? throw new ArgumentNullException(nameof(destinationProperties));
            Revert = revert;
        }
    }
}
