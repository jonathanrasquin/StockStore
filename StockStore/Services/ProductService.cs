using StockStore.Models;

namespace StockStore.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Sock> _socks = new()
        {
            new Sock { Id = 1, Name = "Classic Sock", Description = "A classic white sock.", Price = 5.99m, ImageUrl = "images/socks1.png" },
            new Sock { Id = 2, Name = "Sport Sock", Description = "Perfect for sports activities.", Price = 7.99m, ImageUrl = "images/socks2.png" },
            new Sock { Id = 3, Name = "Winter Sock", Description = "Keeps your feet warm in winter.", Price = 9.99m, ImageUrl = "images/socks3.png" },
            new Sock { Id = 4, Name = ".NET Developer Socks", Description = "For when your code runs smoother than your feet in these cozy .NET socks. Warning: May cause excessive 'dotnet new' commands.", Price = 12.99m, ImageUrl = "images/Socks-.NET-Woodsmoke.png" },
            new Sock { Id = 5, Name = "Angular Blue Socks", Description = "These socks have better dependency injection than your last project. Two-way data binding for your feet!", Price = 11.99m, ImageUrl = "images/Socks-Angular-blue.png" },
            new Sock { Id = 6, Name = "AngularJS Black Socks", Description = "Legacy support for your feet! Perfect for when you miss $scope and digest cycles.", Price = 10.99m, ImageUrl = "images/Socks-AngularJS-Black.png" },
            new Sock { Id = 7, Name = "Arch Linux Socks", Description = "For developers who compile their own morning coffee. Comes with a built-in superiority complex.", Price = 13.99m, ImageUrl = "images/Socks-Arch Linux-Curious Blue.png" },
            new Sock { Id = 8, Name = "AWS Socks (Ecstasy Edition)", Description = "Guaranteed to reduce cold starts—on your feet, not your Lambda. S3 stands for 'Super Soft Socks'.", Price = 14.99m, ImageUrl = "images/Socks-AWS-Ecstasy.png" },
            new Sock { Id = 9, Name = "AWS Socks (Tulip Tree Edition)", Description = "Multi-region, highly available, and just as overpriced as the real thing. Bill your feet to the cloud.", Price = 15.99m, ImageUrl = "images/Socks-AWS-Tulip Tree.png" },
            new Sock { Id = 10, Name = "Azure Socks", Description = "For when you want Microsoft to hug your feet. Comes with free downtime (just kidding… maybe).", Price = 14.99m, ImageUrl = "images/Socks-Azure-Cerulean.png" },
            new Sock { Id = 11, Name = "C# Socks", Description = "NullReferenceException not included. Perfect for LINQ-ing your toes in style.", Price = 12.99m, ImageUrl = "images/Socks-CSharp-Persian Indigo.png" },
            new Sock { Id = 12, Name = "Docker Astronaut Socks", Description = "Contain your smelly feet in style. Supports multi-layer insulation (just like your images).", Price = 15.99m, ImageUrl = "images/Socks-Docker-Astronaut.png" },
            new Sock { Id = 13, Name = "Elasticsearch Socks", Description = "For when you need full-text search on your toes. Warning: May cause cluster headaches.", Price = 16.99m, ImageUrl = "images/Socks-Elastic Search-Ripe Lemon.png" },
            new Sock { Id = 14, Name = "Git Socks", Description = "For those who love `git commit --amend` a little too much. Warning: May cause merge conflicts with sandals.", Price = 11.99m, ImageUrl = "images/Socks-Git-Cinnabar.png" },
            new Sock { Id = 15, Name = "Go Lang Socks", Description = "Compiles faster than you can say 'Where are my generics?' Lightweight, just like Go routines.", Price = 13.99m, ImageUrl = "images/Socks-Go-Cod Gray.png" },
            new Sock { Id = 16, Name = "JavaScript Socks", Description = "Works equally well on frontend and backend feet. NaN% chance of disappointment!", Price = 12.99m, ImageUrl = "images/Socks-Java Script-Golden Dream.png" },
            new Sock { Id = 17, Name = "Kubernetes Socks", Description = "Orchestrate your toes in style. Now with 100% less YAML frustration (socks only, actual K8s not included).", Price = 16.99m, ImageUrl = "images/Socks-Kubernetes-Medium Purple.png" },
            new Sock { Id = 18, Name = "MongoDB Socks", Description = "NoSQL for your feet. Schemaless, just like your weekend coding projects.", Price = 14.99m, ImageUrl = "images/Socks-MongoDB-Kabul.png" },
            new Sock { Id = 19, Name = "Node.js Socks", Description = "Single-threaded but double-layered for maximum comfort. Callback hell not included.", Price = 13.99m, ImageUrl = "images/Socks-NODE.JS-Mine Shaft.png" },
            new Sock { Id = 20, Name = "Python Socks (Ronchi Edition)", Description = "Indentation errors now possible on your feet. Finally, whitespace that matters!", Price = 12.99m, ImageUrl = "images/Socks-Python-Ronchi.png" },
            new Sock { Id = 21, Name = "React Socks", Description = "Because your feet deserve a virtual DOM too. Now with hooks (but not the smelly kind).", Price = 13.99m, ImageUrl = "images/Socks-React-blue.png" },
            new Sock { Id = 22, Name = "TypeScript Socks", Description = "All the JavaScript fun, but with type-safe toes. No more `any` foot odor!", Price = 14.99m, ImageUrl = "images/Socks-TypeScript-Lochmara.png" },
            new Sock { Id = 23, Name = "Vue.js Socks", Description = "Reactive, composable, and just as easy to put on as Vue is to learn.", Price = 13.99m, ImageUrl = "images/Socks-Vue-blue.png" },
            new Sock { Id = 24, Name = "404 Socks Not Found", Description = "For when your feet disappear into the void. Just like your missing semicolon.", Price = 9.99m, ImageUrl = "images/socks-not-found.webp" }

        };
        public Task<List<Sock>> GetProductsAsync()
        {
            return Task.FromResult(_socks);
        }

        public Task<Sock> GetProductByIdAsync(int id)
        {
            var sock = _socks.FirstOrDefault(s => s.Id == id);
            return Task.FromResult(sock);
        }
    }
}
