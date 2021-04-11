using System;

namespace Dealership.Models
{
  public class Car
  {

    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }
    // private string _makeModel;
    // public string makeModel{
    //   get
    //   {
    //     return _makeModel;
    //   }
    //   set{
    //     _makeModel = value;
    //   }
    // }
    // private int _price;
    // private int _miles;

    // public void SetPrice(int newPrice)
    // {
    //   _price = newPrice;
    // }
    // public Car(string makeModel, int price, int miles)
    // {
    //   _makeModel = makeModel;
    //   _price = price;
    //   _miles = miles;
    // }

    // public string GetMakeModel()
    // {
    //   return _makeModel;
    // }

    // public int GetPrice()
    // {
    //   return _price;
    // }

    // public int GetMiles()
    // {
    //   return _miles;
    // }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}




