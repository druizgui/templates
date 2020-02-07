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
    using System;
    using System.Linq;
    using EntityFramework.Providers.Con.Dom;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var databaseConfig = configuration.GetSection("database").Get<DatabaseConfig>();
            var connectionString = databaseConfig.ConnectionStrings[databaseConfig.Provider];
        DbContextOptions<BloggingContext> options = null;

            Console.WriteLine($"Provider: {databaseConfig.Provider}");
            Console.WriteLine($"Connection String: {connectionString}");

            switch (databaseConfig.Provider)
            {
                case "sql":
                    options = new DbContextOptionsBuilder<BloggingContext>()
                        .UseSqlServer(connectionString)
                        .Options;
                    break;

                case "mem":
                    options = new DbContextOptionsBuilder<BloggingContext>()
                        .UseInMemoryDatabase(connectionString)
                        .Options;
                    break;

                case "ora":
                    options = new DbContextOptionsBuilder<BloggingContext>()
                        .UseOracle(connectionString)
                        .Options;
                    break;
            }

            if (options == null) throw new ArgumentException("Database provider");

            using (var uow = new BloggingContext(options))
            {
                // Create
                Console.WriteLine("Inserting a new blog");
                uow.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                uow.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var blog = uow.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post()
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                uow.SaveChanges();

                Console.WriteLine("Press any key to delete");
                Console.ReadKey();

                // Delete
                Console.WriteLine("Delete the blog");
                uow.Remove(blog);
                uow.SaveChanges();
            }
        }
    }
}