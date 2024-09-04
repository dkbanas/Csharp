namespace access;

public class Car
{
    //Code in any assembly can access this type or member.
    //The accessibility level of the containing type controls the accessibility level
    //of public members of the type
    public string brand;
    
    //Only code declared in the same class or struct can access this member.
    private int productionYear;
    
    //Only code in the same assembly can access this type or member.
    internal bool isElectric;

    public Car(string brand, int productionYear, bool isElectric)
    {
        this.brand = brand;
        this.productionYear = productionYear;
        this.isElectric = isElectric;
    }

    public void SetProductionYear(int year)
    {
        this.productionYear = year;
    }

    public int GetProductionYear()
    {
        return this.productionYear;
    }
}