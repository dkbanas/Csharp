using access;

Car myCar = new Car("Tesla", 2021, true);
//Access to public variable
Console.WriteLine($"Brand: {myCar.brand}");

//Access to private variable through public method
Console.WriteLine($"Production Year: {myCar.GetProductionYear()}");

//Changing private variable through public method
myCar.SetProductionYear(2022);
Console.WriteLine($"Updated Production Year: {myCar.GetProductionYear()}");

//Acces to internal variable
Console.WriteLine($"Is Electric: {myCar.isElectric}");
