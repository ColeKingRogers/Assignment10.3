using Assignment10._3.Data;
using Assignment10._3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10._3.Services
{
    public class Crud
    {
        public void AddCar(Cars car)
        {
            Records.context.Cars.Add(car);
            Records.context.SaveChanges(); //save to database
        }
        public List<Cars> GetAllCar()
        {
            return Records.context.Cars.ToList();
        }
        public List<Manufacturer> GetManufacturer()
        {
            return Records.context.Manufacturer.ToList();
        }
        public Cars GetCarByModel(string model)
        {
            return Records.context.Cars.Find(model);
        }
        public void DeleteCar(string model)
        {
            Cars car = Records.context.Cars.Find(model);
            if (car != null)
            {
                Records.context.Cars.Remove(car);
                Records.context.SaveChanges();
            }
        }
        public void UpdateCar(string model, Cars car)
        {
            Cars existingCar = Records.context.Cars.Find(model);
            if (existingCar != null)
            {
                existingCar.Vin = car.Vin;
                existingCar.Model = car.Model;
                existingCar.ManufacturerId = car.ManufacturerId;
                Records.context.SaveChanges();
            }
        }
    }
}
