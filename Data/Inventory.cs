using System;
using System.Collections.Generic;

namespace dotnet6_webapi_jwt.Data
{
    public partial class Inventory
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? Quantity { get; set; }
    }
}
