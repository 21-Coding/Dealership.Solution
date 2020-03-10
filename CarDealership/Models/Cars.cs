using System.Collections.Generic;
namespace CarDealership.Models
{

	public class Car
	{
    public string MakeModel { get; set; }
    public string Message { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _instances = new List<Car> {};

		public Car(string makeModel, string message, int price, int miles)
		{
			MakeModel = makeModel;
			Message = message;
			Price = price;
			Miles = miles;
      _instances.Add(this);
		}
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
		public bool WorthBuying(int maxPrice, int maxMiles)
		{
			return (Price < maxPrice && Miles < maxMiles);
		}
		public static string MakeSound(string sound)
		{
			return "Our cars sound like " + sound;
		}
		public static string MakeFunOfCar(string vehicle)
		{
			return "-slaps roof- this " + vehicle + " can fit so many things in it!";
		}
		public void SetPrice(int newPrice)
		{
			Price = newPrice;
		}

	}
}
        