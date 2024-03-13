using HellocareAssessment.Core.Data.Contexts;
using HellocareAssessment.Model.Entities;

namespace HellocareAssessment.Tests
{
    public static class SeedDataInserter
    {
        public static void Initialize(MainDbContext context)
        {
            if (!context.Companies.Any())
            {
                var company1Id = Guid.Parse("11111111-1111-1111-1111-111111111111");
                var company3Id = Guid.Parse("21111111-1111-1111-1111-111111111111");
                var admin1Id = Guid.Parse("11111111-1111-1111-1111-111111111112");
                var user1Id = Guid.Parse("11111111-1111-1111-1111-111111111113");
                var user3Id = Guid.Parse("31111111-1111-1111-1111-111111111113");
                var product1Id = Guid.Parse("11111111-1111-1111-1111-111111111114");
                var product2Id = Guid.Parse("11111111-1111-1111-1111-111111111115");
                var employee1Id = Guid.Parse("11111111-1111-1111-1111-111111111116");
                var employee2Id = Guid.Parse("11111111-1111-1111-1111-111111111117");

                var company1 = new Company
                {
                    Id = company1Id,
                    Name = "Company 1",
                    InsertedBy = Guid.Parse("11111111-1111-1111-1111-111111111118"),
                    Admins = new List<Admin>(),
                    Products = new List<Product>(),
                    Employees = new List<Employee>()
                };

                var company3 = new Company
                {
                    Id = company3Id,
                    Name = "Company 3",
                    InsertedBy = Guid.Parse("11111111-1111-1111-1111-111111111118"),
                    Admins = new List<Admin>(),
                    Products = new List<Product>(),
                    Employees = new List<Employee>()
                };

                var admin1 = new Admin
                {
                    Id = admin1Id,
                    User = new User
                    {
                        Id = user1Id,
                        Name = "AdminUser 1",
                        InsertedBy = Guid.Parse("11111111-1111-1111-1111-111111111119"),
                        FollowedCompanies = new List<Company>(),
                        FollowedProducts = new List<Product>(),
                        FollowedUsers = new List<User>(),
                        Posts = new List<Post>()
                    },
                    Company = company1,
                    InsertedBy = Guid.Parse("11111111-1111-1111-1111-111111111120")
                };

                var admin3 = new Admin
                {
                    Id = Guid.NewGuid(),
                    Company = company3,
                    User = new User()
                    { Id = user3Id, Name = "User 3", InsertedBy = admin1Id },
                    InsertedBy = user1Id,
                };

                var product1 = new Product
                {
                    Id = product1Id,
                    Name = "Product 1",
                    ParentCompany = company1,
                    InsertedBy = Guid.Parse("11111111-1111-1111-1111-111111111121"),
                    Followers = new List<User>(),
                    Posts = new List<Post>()
                };

                var product2 = new Product
                {
                    Id = product2Id,
                    Name = "Product 2",
                    ParentCompany = company1,
                    InsertedBy = Guid.Parse("11111111-1111-1111-1111-111111111122"),
                    Followers = new List<User>(),
                    Posts = new List<Post>()
                };

                var employee1 = new Employee
                {
                    Id = employee1Id,
                    User = admin1.User,
                    Company = company1,
                    InsertedBy = Guid.Parse("11111111-1111-1111-1111-111111111123")
                };

                var employee2 = new Employee
                {
                    Id = employee2Id,
                    User = admin1.User,
                    Company = company1,
                    InsertedBy = Guid.Parse("11111111-1111-1111-1111-111111111124")
                };

                company1.Admins.Add(admin1);
                company1.Products.Add(product1);
                company1.Products.Add(product2);
                company1.Employees.Add(employee1);
                company1.Employees.Add(employee2);

                admin1.User.FollowedProducts.Add(product2);
                admin1.User.FollowedUsers.Add(admin3.User);
                admin1.User.FollowedCompanies.Add(company3);

                var company2Id = Guid.Parse("22222222-2222-2222-2222-222222222222");
                var admin2Id = Guid.Parse("22222222-2222-2222-2222-222222222223");
                var user2Id = Guid.Parse("22222222-2222-2222-2222-222222222224");
                var product3Id = Guid.Parse("22222222-2222-2222-2222-222222222225");
                var product4Id = Guid.Parse("22222222-2222-2222-2222-222222222226");
                var employee3Id = Guid.Parse("22222222-2222-2222-2222-222222222227");
                var employee4Id = Guid.Parse("22222222-2222-2222-2222-222222222228");

                var company2 = new Company
                {
                    Id = company2Id,
                    Name = "Company 2",
                    InsertedBy = Guid.Parse("22222222-2222-2222-2222-222222222229"),
                    Admins = new List<Admin>(),
                    Products = new List<Product>(),
                    Employees = new List<Employee>()
                };

                var admin2 = new Admin
                {
                    Id = admin2Id,
                    User = new User
                    {
                        Id = user2Id,
                        Name = "AdminUser 2",
                        InsertedBy = Guid.Parse("22222222-2222-2222-2222-222222222230"),
                        FollowedCompanies = new List<Company>(),
                        FollowedProducts = new List<Product>(),
                        Posts = new List<Post>()
                    },
                    Company = company2,
                    InsertedBy = Guid.Parse("22222222-2222-2222-2222-222222222231")
                };

                var product3 = new Product
                {
                    Id = product3Id,
                    Name = "Product 3",
                    ParentCompany = company2,
                    InsertedBy = Guid.Parse("22222222-2222-2222-2222-222222222232"),
                    Followers = new List<User>(),
                    Posts = new List<Post>()
                };

                var product4 = new Product
                {
                    Id = product4Id,
                    Name = "Product 4",
                    ParentCompany = company2,
                    InsertedBy = Guid.Parse("22222222-2222-2222-2222-222222222233"),
                    Followers = new List<User>(),
                    Posts = new List<Post>()
                };

                var employee3 = new Employee
                {
                    Id = employee3Id,
                    User = admin2.User,
                    Company = company2,
                    InsertedBy = Guid.Parse("22222222-2222-2222-2222-222222222234")
                };

                var employee4 = new Employee
                {
                    Id = employee4Id,
                    User = admin2.User,
                    Company = company2,
                    InsertedBy = Guid.Parse("22222222-2222-2222-2222-222222222235")
                };

                company2.Admins.Add(admin2);
                company2.Products.Add(product3);
                company2.Products.Add(product4);
                company2.Employees.Add(employee3);
                company2.Employees.Add(employee4);

                var post1 = new Post
                {
                    Id = Guid.NewGuid(),
                    Company = company1,
                    Content = "Post 1",
                    InsertedBy = Guid.NewGuid(),
                };

                var post2 = new Post
                {
                    Id = Guid.NewGuid(),
                    Company = company1,
                    Content = "Post 2",
                    InsertedBy = Guid.NewGuid(),
                    InsertedAt = DateTime.Now.AddDays(-1),
                };

                var post3 = new Post
                {
                    Id = Guid.NewGuid(),
                    Company = company1,
                    Content = "Post 3",
                    InsertedBy = Guid.NewGuid(),
                    InsertedAt = DateTime.Now.AddDays(-2),
                };

                var post4 = new Post
                {
                    Id = Guid.NewGuid(),
                    Product = product2,
                    Content = "Post 4",
                    InsertedBy = Guid.NewGuid(),
                    InsertedAt = DateTime.Now.AddDays(-3),
                };

                var post5 = new Post
                {
                    Id = Guid.NewGuid(),
                    Company = company2,
                    Content = "Post 5",
                    InsertedBy = Guid.NewGuid(),
                    InsertedAt = DateTime.Now.AddDays(-3),
                };

                var post6 = new Post
                {
                    Id = Guid.NewGuid(),
                    Company = company3,
                    Content = "Post 6",
                    InsertedBy = Guid.NewGuid(),
                    InsertedAt = DateTime.Now.AddDays(-3),
                };

                var post7 = new Post
                {
                    Id = Guid.NewGuid(),
                    User = admin3.User,
                    Content = "Post 7",
                    InsertedBy = Guid.NewGuid(),
                    InsertedAt = DateTime.Now.AddDays(-3),
                };

                var post8 = new Post
                {
                    Id = Guid.NewGuid(),
                    Product = product3,
                    Content = "Post 8",
                    InsertedBy = Guid.NewGuid(),
                    InsertedAt = DateTime.Now.AddDays(-10),
                };


                context.AddRange(company1, admin1.User, product1, product2, employee1, employee2,
                                  company2, admin2.User, product3, product4, employee3, employee4,
                                  post1, post2, post3, post4, post5, post6, post7, admin3, company3, post8);

                context.SaveChanges();
            }
        }
    }
}
