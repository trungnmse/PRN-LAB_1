
using AutomobileLibrary.BusinessObject;

namespace AutomobileLibrary.DataAccess
{
    public class CarDbContext
    {
        private static readonly List<Car> _carList = new() {
            new Car{CarId = 1, CarName="CVR", Manufacturer="Honda", Price=30000, ReleaseYear=2021},
            new Car{CarId = 2, CarName="CVR", Manufacturer="Ford Foucus", Price=15000, ReleaseYear=2022}
        };

        private static CarDbContext? dbContext;
        private static readonly object instanceLock = new();
        private CarDbContext() { }

        public static CarDbContext GetDbContext
        {
            get
            {
                lock (instanceLock)
                {
                    return dbContext ??= new CarDbContext();
                }
            }
        }

        public List<Car> GetCars => _carList;
        public Car? GetCarById(int carId)
        {
            return _carList.SingleOrDefault(car => car.CarId == carId);
        }

        public void AddCar(Car car)
        {
            Car? existCar = GetCarById(car.CarId);
            if (existCar == null)
            {
                _carList.Add(car);
            }
        }

        public void Update(Car car)
        {
            Car? existCar = GetCarById(car.CarId);
            if (existCar != null)
            {
                int index = _carList.IndexOf(existCar);
                _carList[index] = car;
            }
            else
            {
                throw new Exception("Car does not exist!");
            }

        }

        public void Remove(int carId)
        {
            Car? existCar = GetCarById(carId);
            if (existCar != null)
            {
                _carList.Remove(existCar);
            }
            else
            {
                throw new Exception("Car does not already exist");
            }
        }
    }
}
