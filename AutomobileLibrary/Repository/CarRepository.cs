using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAccess;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int carId)
        {
            CarDbContext.GetDbContext.Remove(carId);
        }

        public Car? GetCarById(int carId)
        {
            return CarDbContext.GetDbContext.GetCarById(carId);
        }

        public IEnumerable<Car> GetCars()
        {
            return CarDbContext.GetDbContext.GetCars;
        }

        public void InsertCar(Car car)
        {
            CarDbContext.GetDbContext.AddCar(car);
        }

        public void UpdateCar(Car car)
        {
            CarDbContext.GetDbContext.Update(car);
        }
    }
}
