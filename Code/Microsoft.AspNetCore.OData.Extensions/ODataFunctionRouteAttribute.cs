using Microsoft.AspNetCore.OData.Routing;

namespace Microsoft.AspNetCore.OData.Extensions
{
    public class ODataFunctionRouteAttribute : ODataRouteAttribute
    {
        public ODataFunctionRouteAttribute(string entitySet, string functionName, string @namespace = null)
            : base($"{entitySet}/{@namespace ?? "OData"}.{functionName}")
        {

        }
    }
}
