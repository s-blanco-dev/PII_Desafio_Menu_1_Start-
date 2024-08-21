namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string name;

    public string Name
    {
        get
        {
            return this.name;
        }
        
    }

    private double price;

    public double Price
    {
        get
        {
            return this.price;
        }
    }

    private bool isVegetarian;
    public bool IsVegetarian
    {
        get
        {
            return this.isVegetarian;
        }
    }

    public Dish(string name, double price, bool isVegetarian)
    {
        this.name = name;
        this.price = price;
        this.isVegetarian = isVegetarian;
    }
}