// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------
namespace EntityFramework.Providers.Con
{
    using System.Collections.Generic;

    public class DatabaseConfig
    {
        public string Provider { get; set; }
        public Dictionary<string,string> ConnectionStrings { get; set; }
    }
}