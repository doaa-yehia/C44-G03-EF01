using Assignment.DatabaseContext;
using Assignment.Models.AirLineModel;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using ITIDbContext dbContext= new ITIDbContext();
            using AirlineDbContext dbContext = new AirlineDbContext();

            #region Apply CRUD Operations

            #region A.Insert a new airline

            #region a

            //var Airline01 = new Airline()
            //{
            //    Name = "EgyptAir",
            //    Cont_Person = "Ahmed Ali",
            //    Airline_Phones = new List<Airline_Phone>()
            //    {
            //        new Airline_Phone{Phone="0123456789"},
            //        new Airline_Phone{Phone="0113654789"}
            //    },
            //    Address = "Cairo"

            //};
            //dbContext.Airlines.Add(Airline01);
            //dbContext.SaveChanges(); 

            #endregion

            #region b

            ///Add a new aircraft

            //var EgyAirline = dbContext.Airlines.FirstOrDefault(A => A.Name == "EgyptAir");

            //if(EgyAirline is not null)
            //{
            //    var Aircraft01 = new Aircraft()
            //    {
            //        Model = "Model01",
            //        Capacity = 180,
            //        AL_Aircraft = EgyAirline
            //    };
            //    dbContext.Aircrafts.Add(Aircraft01);
            //    dbContext.SaveChanges();
            //    Console.WriteLine("Done");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}


            #endregion

            #region c
            ///Record a new transaction

            // var EgyAirline = dbContext.Airlines.FirstOrDefault(A => A.Name == "EgyptAir");

            //if(EgyAirline is not null )
            // {
            //     var Trans01 = new Transaction()
            //     {
            //         Amount = 50000,
            //         Description = "Tickets",
            //         TransAirline = EgyAirline
            //     };
            //     dbContext.Transactions.Add(Trans01);
            //     dbContext.SaveChanges();
            //     Console.WriteLine("Done");
            // }
            // else
            // {
            //     Console.WriteLine("Failed");
            // }

            #endregion

            #region d
            ///Select all employees who work in "EgyptAir".

            //var EgyAirline = dbContext.Airlines.Include(a => a.Employees).FirstOrDefault(A => A.Name == "EgyptAir");

            //if (EgyAirline is not null)
            //{
            //    foreach (var Emp in EgyAirline.Employees)
            //    {
            //        Console.WriteLine($"EmpName= {Emp.Name}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            //another Way

            //var EgyAirline = (from e in dbContext.Employees
            //                 where e.EmpAirline.Name== "EgyptAir"
            //                 select e).ToList();

            //if (EgyAirline is not null)
            //{
            //    foreach (var Emp in EgyAirline)
            //    {
            //        Console.WriteLine($"EmpName= {Emp.Name}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}
            #endregion

            #region e
            ///Show all transactions (id, description, amount) recorded by "EgyptAir".

            //var EgyAirline = dbContext.Airlines.Include(a => a.Transactions).FirstOrDefault(A => A.Name == "EgyptAir");

            //if (EgyAirline is not null)
            //{
            //    foreach (var Trans in EgyAirline.Transactions)
            //    {
            //        Console.WriteLine($"Id ={Trans.Id}\nDiscription = {Trans.Description}\nAmount = {Trans.Amount}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            #endregion

            #region f
            /// Get the total number of employees working in each airline.

            //var EmployeeCount = dbContext.Employees.Include(e => e.EmpAirline)
            //                                       .GroupBy(e => e.EmpAirline.Name)
            //                                       .Select(g => new
            //                                       {
            //                                           AirlineName = g.Key,
            //                                           Count = g.Count()
            //                                       }).ToList();

            //foreach (var item in EmployeeCount)
            //{
            //    Console.WriteLine($"AirlineName={item.AirlineName}/nEmpCount= {item.Count}");
            //}
            #endregion

            #region g
            ///Change the capacity of the “Model01” aircraft to 200.

            //var aircraft01 = dbContext.Aircrafts.FirstOrDefault(A => A.Model == "Model01");

            //if (aircraft01 is not null)
            //{
            //    aircraft01.Capacity = 200;
            //    Console.WriteLine(dbContext.Entry<Aircraft>(aircraft01).State); //Modified
            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry<Aircraft>(aircraft01).State); //Unchanged


            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}
            #endregion

            #region h
            ///Delete all transactions older than 2020.

            //DateTime targetDate = new DateTime(2020, 1, 1);
            //var trasOrder2020 = dbContext.Transactions.Where(A => A.Date < targetDate).ToList();

            //if (trasOrder2020.Any())
            //{
            //    dbContext.RemoveRange(trasOrder2020);
            //    Console.WriteLine(dbContext.Entry<Transaction>(trasOrder2020[0]).State); //Deleted

            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry<Transaction>(trasOrder2020[0]).State); //Detached


            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            #endregion

            #region i
            ///Insert a new route from "Cairo" to "Dubai", 
            ///classification "International", distance 2400 km.

            //var Route01 = new Route()
            //{
            //    Origin = "Cairo",
            //    Distination = "Dubai",
            //    Classification = "International",
            //    Distance = 2400
            //};

            //dbContext.Routes.Add(Route01);
            //Console.WriteLine(dbContext.Entry<Route>(Route01).State); //Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry<Route>(Route01).State); //Unchanged


            #endregion

            #region j
            ///Assign “Model01” aircraft to Route From "Cairo" to "Dubai".
            ///With duration 4 hours, price 3000 LE

            //var modelAircraft = dbContext.Aircrafts.FirstOrDefault(A => A.Model == "Model01");

            //var Route01 = new Route()
            //{
            //    Origin = "Cairo",
            //    Distination = "Dubai",
            //    Classification = "International",
            //    Distance = 100

            //};
            //var AirCraftRout = new Aircraft_Route()
            //{
            //    Price = 3000,
            //    Route=Route01,
            //    Departure=DateTime.Now,
            //    Arrival=DateTime.Now.AddHours(4),
            //    Num_Of_Pass=0

            //};

            //Route01.A_Aircrafts.Add(AirCraftRout);

            //if (modelAircraft is not null)
            //{
            //    modelAircraft.ARoutes.Add(AirCraftRout);
            //    dbContext.Add(Route01);

            //    Console.WriteLine(dbContext.Entry<Route>(Route01).State); //Added

            //    dbContext.SaveChanges();
            //    Console.WriteLine(dbContext.Entry<Route>(Route01).State); //Unchanged

            //}


            #endregion

            #endregion

            #endregion
        }
    }
}
