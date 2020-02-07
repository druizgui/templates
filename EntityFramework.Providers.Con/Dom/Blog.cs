// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------

namespace EntityFramework.Providers.Con.Dom
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Blog
    {
        [Key] public int BlogId { get; set; }

        public string Url { get; set; }

        [InverseProperty("Blog")] public virtual ICollection<Post> Posts { get; set; }

        public Blog()
        {
            Posts = new HashSet<Post>();
        }
    }
}