using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public static class ModelbuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carrier>().HasData(
                new Carrier
                {
                    Id = 1,
                    //Name = "satish",
                    Bussiness_Name = "satish Lic",
                    MyProperty = "testproperty1",
                    Bussiness_Address = "satish test business address",
                    Bussiness_Phone_Number = "12345678"
                },
                new Carrier
                {
                    Id = 2,
                    //Name = "satish",
                    Bussiness_Name = "Lic New",
                    MyProperty = "testproperty2",
                    Bussiness_Address = "parimi test business address",
                    Bussiness_Phone_Number = "12345678"
                }
                );

            modelBuilder.Entity<MGA>().HasData(
               new MGA
               {
                   Id = 1,
                   //Name = "satish",
                   Bussiness_Name = "satish MGA",
                   MyProperty = "testproperty1",
                   Bussiness_Address = "satish test business address",
                   Bussiness_Phone_Number = "12345678"
               },
               new MGA
               {
                   Id = 2,
                   //Name = "satish",
                   Bussiness_Name = "Lic New MGA",
                   MyProperty = "testproperty2",
                   Bussiness_Address = "parimi test business address",
                   Bussiness_Phone_Number = "12345678"
               }
               );
            modelBuilder.Entity<Advisor>().HasData(
              new Advisor
              {
                  Id = 1,
                  //Name = "satish",
                  First_Name = "satish Advisor",
                  Address = "testproperty1",
                  Last_Name = "parimi",
                  Phone_Number = "12345678"
              },
              new Advisor
              {
                  Id = 2,
                  //Name = "satish",
                  First_Name = "Raj Advisor",
                  Address = "testproperty1",
                  Last_Name = "kumar",
                  Phone_Number = "12345678"
              }
              );
        }
    }
}
