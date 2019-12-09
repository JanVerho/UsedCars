using Microsoft.EntityFrameworkCore;
using System.Collections;
using UsedCars.Model;

namespace UsedCars.Data
{
    public static class ModelBuilderExtensions
    {
        // moet static class zijn!!! else error CS1106: Extension method must be defined … https://social.msdn.microsoft.com/Forums/silverlight/en-US/e463b691-6ccd-4fea-b925-26dd77c3821a/error-cs1106-extension-method-must-be-defined-in-a-nongeneric-static-class

        public static ModelBuilder Seed(this ModelBuilder modelBuilder)
        {
            // 1. hier de op te laden data plaatsen

            ArrayList AllObjects = new ArrayList();
            object obj = new Car(1, "volvoObj", 12500, "groen", 2000, 20000);
            AllObjects.Add(obj);

            obj = new Car(9, "volvoObj2", 22000, "geel", 2017, 0);
            AllObjects.Add(obj);
            obj = new Car(10, "volvoObj3", 20000, "geel", 2011, 0);
            AllObjects.Add(obj);

            modelBuilder.Entity<Car>().HasData(
            new Car(2, "volvo", 28000, "zwart", 2018, 0),
            new Car(3, "volvo", 25000, "grijs", 2017, 0),
            new Car(4, "audi", 35000, "grijs", 2017, 0),
            new Car(5, "audi", 30000, "rood", 2015, 0),
            new Car(6, "renault", 18000, "blauw", 2015, 0),
            new Car(7, "nissan", 21000, "blauw", 2016, 0),
            new Car(8, "vw", 15000, "groen", 2012, 0)
            );

            // 2. vervolgens scripts @cmd:

            #region Script cmd

            // 1. preAction: Activate dotnet-ef (only once)
            //  Open cmd box
            //  dotnet tool install--global dotnet-ef--version 3.0
            //  close cmd box!!!!
            // 2. create migration folder & files
            //  Open new cmd box on UsedCars / UsedCars folder
            //  dotnet ef migrations add CreateDatabase --output -dir Data/Migrations
            // 3. create ... .db in root folder
            //  In cmd box:
            //  dotnet ef database update

            #endregion Script cmd

            foreach (Car item in AllObjects)
            {
                modelBuilder.Entity<Car>().HasData(item);
            }

            return modelBuilder;
        }

        //Color seed
        public static ModelBuilder SeedColor(this ModelBuilder modelBuilder)
        {
            // 1. hier de op te laden data plaatsen

            modelBuilder.Entity<Color>().HasData(
            new Color(1, "rood"),
            new Color(2, "zwart"),
            new Color(3, "grijs"),
            new Color(4, "groen"),
            new Color(5, "blauw"),
            new Color(6, "roze")
                );

            // 2. vervolgens scripts @cmd:

            #region Script cmd

            // 1. preAction: Activate dotnet-ef (only once)
            //  Open cmd box
            //  dotnet tool install--global dotnet-ef--version 3.0
            //  close cmd box!!!!
            // 2. create migration folder & files
            //  Open new cmd box on UsedCars / UsedCars folder
            //  dotnet ef migrations add CreateDatabase --output - dir Data / Migrations
            // 3. create ... .db in root folder
            //  In cmd box:
            //  dotnet ef database update

            #endregion Script cmd

            return modelBuilder;
        }
    }
}