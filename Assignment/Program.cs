using Assignment.DatabaseContext;
using Assignment.Models.AirLineModel;

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

            var Airline01 = new Airline()
            {
                Name = "EgyptAir",
                Cont_Person = "Ahmed Ali",
                Airline_Phones = new List<Airline_Phone>()
                {
                    new Airline_Phone{Phone="0123456789"},
                    new Airline_Phone{Phone="0113654789"}
                },
                Address = "Cairo"

            };
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

            //var EgyAirline = dbContext.Airlines.FirstOrDefault(A => A.Name == "EgyptAir");

            //if(EgyAirline is not null)
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



            #endregion

            #endregion
        }
    }
}
