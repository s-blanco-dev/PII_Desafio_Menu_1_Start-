using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private ArrayList assignedTables = new ArrayList();
    
    // Nombre del mozo
    private string name;
    public string Name
    {
        get { return name; }
    }

    // Método constructor
    public Waiter(string name)
    {
        this.name = name;
    }

    // Agrega un objeto mesa al Array assignedTable 
    public void AssignTable(Table table)
    {
        this.assignedTables.Add(table);
    }

        // Agrega un plato a la lista de pedidos de la mesa indicada
    public void TakeOrder(Table table, Dish dish)
    {
        table.AddToOrder(dish);
    }
}