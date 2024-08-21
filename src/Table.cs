namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private int number;
    private Boolean isOccupied;
    private ArrayList order = new ArrayList();

    public Table(int number)
    {
        this.number = number;
    }

    public int Number
    {
        get => number;
        set => number = value;
    }

    public bool IsOccupied
    {
        get => isOccupied;
        set => isOccupied = value;
    }

    public ArrayList Order
    {
        get => order;
        set => order = value;
    }

    public void Occupy()
    {
        this.isOccupied = true;
    }

    public void Free()
    {
        this.isOccupied = false;
        this.order.Clear();
    }

    public void AddToOrder(Dish dish)
    {
        this.order.Add(dish);
    }
    
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
}