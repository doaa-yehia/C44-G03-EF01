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



            #endregion

            #endregion
        }
    }
}
