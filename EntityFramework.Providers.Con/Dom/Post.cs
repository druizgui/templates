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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Post
    {
        [Key] public int PostId { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        [InverseProperty("Posts")]
        public virtual Blog Blog { get; set; }
    }
}