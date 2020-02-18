using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Portfolio.Models
{
    public static class DbInitializer
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PortfolioDbContext context = app.ApplicationServices.GetRequiredService<PortfolioDbContext>();
            context.Database.Migrate();

            if (!context.Homes.Any())
            {
                var homes = new Home[]
                {
                new Home {
                    ID = Guid.NewGuid(),
                    Title = "Edib Šupić",
                    Image = "",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis quis erat quis dui lobortis luctus. Vivamus nec lacus in nisl condimentum fringilla vel quis tortor.Nulla facilisi.Sed ultrices vitae turpis sagittis facilisis.Phasellus aliquet leo vel imperdiet laoreet.Curabitur viverra finibus velit, at bibendum libero eleifend eget.Pellentesque sed scelerisque ipsum, nec malesuada leo."
                }
                };
                foreach (Home h in homes)
                {
                    context.Homes.Add(h);
                }
                context.SaveChanges();
            }
            if (!context.Educations.Any())
            {
                var educations = new Education[]
                    {
                    new Education()
                    {
                        ID = Guid.NewGuid(),
                        Title = "Pro C# 7 With .NET and .NET Core",
                        Description = "This essential classic title provides a comprehensive foundation in the C# programming language and the frameworks it lives in. Now in its 8th edition, you’ll find all the very latest C# 7.1 and .NET 4.7 features here, along with four brand new chapters on Microsoft’s lightweight, cross-platform framework, .NET Core, up to and including .NET Core 2.0. Coverage of ASP.NET Core, Entity Framework (EF) Core, and more, sits alongside the latest updates to .NET, including Windows Presentation Foundation (WPF), Windows Communication Foundation (WCF), and ASP.NET MVC. Dive in and discover why Pro C# has been a favorite of C# developers worldwide for over 15 years. Gain a solid foundation in object-oriented development techniques, attributes and reflection, generics and collections as well as numerous advanced topics not found in other texts (such as CIL opcodes and emitting dynamic assemblies). With the help of this book you’ll have the confidence to put C# into practice and explore the .NET universe on your own terms.",
                        Image = "",
                        OrderLink = "",
                    },
                    new Education()
                    {
                        ID = Guid.NewGuid(),
                        Title = "Pro ASP.NET Core MVC 2",
                        Description = "HTML5 is more than a markup language—it’s a collection of several independent web standards. Fortunately, this expanded guide covers everything you need in one convenient place. With step-by-step tutorials and real-world examples, HTML5: The Missing Manual shows you how to build web apps that include video tools, dynamic graphics, geolocation, offline features, and responsive layouts for mobile devices.",
                        Image = "",
                        OrderLink = "",
                    },
                    new Education()
                    {
                        ID = Guid.NewGuid(),
                        Title = "Learning React Functional Web Development with React and Redux",
                        Description = "If you want to learn how to build efficient user interfaces with React, this is your book. Authors Alex Banks and Eve Porcello show you how to create UIs with this small JavaScript library that can deftly display data changes on large-scale, data-driven websites without page reloads. Along the way, you’ll learn how to work with functional programming and the latest ECMAScript features.",
                        Image = "",
                        OrderLink = "",
                    },
                    new Education()
                    {
                        ID = Guid.NewGuid(),
                        Title = "You Don't Know JS",
                        Description = "No matter how much experience you have with JavaScript, odds are you don't fully understand the language. This concise yet in-depth guide takes you inside scope and closures, two core concepts you need to know to become a more efficient and effective JavaScript programmer. You'll learn how and why they work, and how an understanding of closures can be a powerful part of your development skillset.",
                        Image = "",
                        OrderLink = "",
                    },
                    new Education()
                    {
                        ID = Guid.NewGuid(),
                        Title = "CSS: The Missing Manual",
                        Description = "SS lets you create professional-looking websites, but learning its finer points can be tricky—even for seasoned web developers. This fully updated edition provides the most modern and effective tips, tricks, and tutorial-based instruction on CSS available today. Learn how to use new tools such as Flexbox and Sass to build web pages that look great and run fast on any desktop or mobile device. Ideal for casual and experienced designers alike.",
                        Image = "",
                        OrderLink = "",
                    },
                    };
                foreach (Education e in educations)
                {
                    context.Educations.Add(e);
                }
                context.SaveChanges();
            }
            if (!context.Projects.Any())
            {
                var projects = new Projects[]
                    {
                    new Projects()
                    {
                        ID = Guid.NewGuid(),
                        Title = "x-o",
                        Description = "Simple x-o built in python using turtle for animations. Maybe the most inefficient way to build x-o but it was my first application that wasn't console based so I'm proud of it.",
                        GithubLink = "https://github.com/Isutary/x-o",
                        Website = "",
                    },
                    new Projects()
                    {
                        ID = Guid.NewGuid(),
                        Title = "heap-bst",
                        Description = "Binary search tree that maintains balance by maintaining heap property relative to randomly assigned weights to each node.",
                        GithubLink = "https://github.com/Isutary/heap-bst",
                        Website = "",
                    },
                    new Projects()
                    {
                        ID = Guid.NewGuid(),
                        Title = "polynomial-calculator",
                        Description = "Calculator for polynomials.",
                        GithubLink = "",
                        Website = "",
                    },
                    new Projects()
                    {
                        ID = Guid.NewGuid(),
                        Title = "dfa",
                        Description = "Program that test whether deterministic finite automaton(DFA) will accept given string or not.",
                        GithubLink = "",
                        Website = "",
                    },
                    new Projects()
                    {
                        ID = Guid.NewGuid(),
                        Title = "hash-table",
                        Description = "Hash table implementation in JavaScript.",
                        GithubLink = "https://github.com/Isutary/hash-table",
                        Website = "",
                    },
                    new Projects()
                    {
                        ID = Guid.NewGuid(),
                        Title = "tft-team-builder",
                        Description = "Simple Teamfight Tactics team builder.",
                        GithubLink = "",
                        Website = "",
                    },
                    new Projects()
                    {
                        ID = Guid.NewGuid(),
                        Title = "tft-team-builder-react",
                        Description = "The Teamfight tactis team builder built using React.js.",
                        GithubLink = "https://github.com/Isutary/tft-team-builder-react",
                        Website = "https://tft-team-builder.herokuapp.com/",
                    },
                    new Projects()
                    {
                        ID = Guid.NewGuid(),
                        Title = "simple-quiz",
                        Description = "Simple quiz app",
                        GithubLink = "",
                        Website = "",
                    },
                    new Projects()
                    {
                        ID = Guid.NewGuid(),
                        Title = "responsive-nav-react",
                        Description = "Responsive navigation built in React.js.",
                        GithubLink = "",
                        Website = "",
                    },
                    };
                foreach (Projects p in projects)
                {
                    context.Projects.Add(p);
                }
                context.SaveChanges();
            }
            if (!context.Contacts.Any())
            {
                var contacts = new Contact[]
                    {
                    new Contact
                    {
                        ID = Guid.NewGuid(),
                        Name = "Edib",
                        Email = "edib@mail.com",
                        Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean eu maximus erat. In ultricies tempus ex in convallis. Vivamus eros lectus, malesuada at pellentesque id, malesuada sed est. In libero velit, ultrices et mi vitae, pretium eleifend tortor. Suspendisse accumsan, neque aliquam lacinia pulvinar, nisl eros varius magna, eget auctor elit diam eu nisi.",
                        isRead = false
                    },
                    new Contact
                    {
                        ID = Guid.NewGuid(),
                        Name = "Azra",
                        Email = "azra@hotmail.com",
                        Message = "Quisque in sollicitudin lectus. Nulla tincidunt ultricies ligula, ac maximus nibh sodales et. Integer ullamcorper sem vel metus accumsan, in feugiat nisi maximus. Nam molestie convallis arcu.",
                        isRead = false
                    },
                    new Contact
                    {
                        ID = Guid.NewGuid(),
                        Name = "Anes",
                        Email = "anes@gmail.com",
                        Message = "Ut rutrum ligula quis massa dapibus commodo a id ipsum. Nunc in condimentum arcu. Nullam ut pellentesque urna, in mattis justo. Pellentesque auctor mi at dolor euismod suscipit. Cras elementum, ex in consectetur rutrum, nisl lectus congue nunc, eget congue orci sapien eu mauris. Nam id purus non ex cursus feugiat nec eget sapien. Suspendisse pellentesque diam nec ipsum fringilla, ac interdum sem dictum. Curabitur porta lobortis eros, sed blandit risus scelerisque quis. Ut risus tortor, faucibus et elit ut, fringilla dapibus mi. Integer a pretium mauris. Donec sit amet consectetur urna.",
                        isRead = false
                    },
                    new Contact
                    {
                        ID = Guid.NewGuid(),
                        Name = "Deniz",
                        Email = "deniz@yahoo.com",
                        Message = "Enn vehicula elit in lectus condimentum, id rutrum metus pulvinar. Nullam et eros dolor. Nulla vel rutrum tortor, et tempor massa. In molestie efficitur arcu a dictum.",
                        isRead = false
                    },
                    };
                foreach (Contact c in contacts)
                {
                    context.Contacts.Add(c);
                }
                context.SaveChanges();
            }
        }
    }
}
