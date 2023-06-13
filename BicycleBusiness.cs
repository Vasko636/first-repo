using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class BicycleBusiness
    {
        private BicycleContext bicycleContext;
        public void AddBike(Bike bike)
        {
            BicycleContext context = new BicycleContext();
            context.Bike.Add(bike);
            context.SaveChanges();
        }
        public void DeleteBike(int id)
        {
            BicycleContext context = new BicycleContext();
            var bike = context.Bike.Find(id);
            if (bike != null)
            {
                context.Bike.Remove(bike);
                context.SaveChanges();
            }
        }
        public void UpdateBike(Bike bike)
        {
            BicycleContext context = new BicycleContext();
            var item = context.Bike.Find(bike.Id);
            if (item != null)
            {
                context.Entry(item).CurrentValues.SetValues(bike);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Bike not found!");
            }
        }
        public List<Bike> GetAllBikes()
        {
            BicycleContext context = new BicycleContext();
            return context.Bike.ToList();
        }
        public Bike GetBikes(int id)
        {
            using (bicycleContext=new BicycleContext())
            {
                return bicycleContext.Bike.Find(id);
            }
        }

        public void AddBrand(Brand brand)
        {
            BicycleContext context = new BicycleContext();
            context.Brand.Add(brand);
            context.SaveChanges();
        }
        public void DeleteBrand(int id)
        {
            BicycleContext context = new BicycleContext();
            var brand = context.Brand.Find(id);
            if (brand != null)
            {
                context.Brand.Remove(brand);
                context.SaveChanges();
            }
        }
        public void UpdateBrand(Brand brand)
        {
            BicycleContext context = new BicycleContext();
            var item = context.Brand.Find(brand.Id);
            if (item != null)
            {
                context.Entry(item).CurrentValues.SetValues(brand);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Brand not found!");
            }
        }
        public List<Brand> GetAllBrands()
        {
            BicycleContext context = new BicycleContext();
            return context.Brand.ToList();
        }
        public void AddColor(Colour color)
        {
            BicycleContext context = new BicycleContext();
            context.Colour.Add(color);
            context.SaveChanges();
        }
        public Brand GetBrand(int id)
        {
            using (bicycleContext = new BicycleContext())
            {
                return bicycleContext.Brand.Find(id);
            }
        }
        public void DeleteColor(int id)
        {
            BicycleContext context = new BicycleContext();
            var color = context.Colour.Find(id);
            if (color != null)
            {
                context.Colour.Remove(color);
                context.SaveChanges();
            }
        }
        public void UpdateColor(Colour color)
        {
            BicycleContext context = new BicycleContext();
            var item = context.Colour.Find(color.Id);
            if (item != null)
            {
                context.Entry(item).CurrentValues.SetValues(color);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Color not found!");
            }
        }
        public List<Colour> GetAllCountries()
        {
            BicycleContext context = new BicycleContext();
            return context.Colour.ToList();
        }
        public Colour GetColour(int id)
        {
            using (bicycleContext = new BicycleContext())
            {
                return bicycleContext.Colour.Find(id);
            }
        }
        public void AddTyre(Tyres tyre)
        {
            BicycleContext context = new BicycleContext();
            context.Tyres.Add(tyre);
            context.SaveChanges();
        }
        public void DeleteTyre(int id)
        {
            BicycleContext context = new BicycleContext();
            var tyre = context.Tyres.Find(id);
            if (tyre != null)
            {
                context.Tyres.Remove(tyre);
                context.SaveChanges();
            }
        }
        public void UpdateTyre(Tyres tyre)
        {
            BicycleContext context = new BicycleContext();
            var item = context.Tyres.Find(tyre.Id);
            if (item != null)
            {
                context.Entry(item).CurrentValues.SetValues(tyre);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Tyre not found!");
            }
        }
        public List<Tyres> GetAllTyres()
        {
            BicycleContext context = new BicycleContext();
            return context.Tyres.ToList();
        }
        public Tyres GetTyres(int id)
        {
            using (bicycleContext = new BicycleContext())
            {
                return bicycleContext.Tyres.Find(id);
            }
        }
    }
}

