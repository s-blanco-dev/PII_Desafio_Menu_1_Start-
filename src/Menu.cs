namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();
    
    public void AddDish(Dish dish)
    {
        if (dish != null)
        {
            dishes.Add(dish);
        }
    }
    
    public void RemoveDish(Dish dish)
    {
        if (dish != null && dishes.Contains(dish))
        {
            dishes.Remove(dish);
        }
    }

    public Dish GetDishByName(string name)
    {
        foreach (Dish dish in dishes)
        {
            if (dish.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
            {
                return dish;
                
            }

            return null;
        }
        
        return null;
    }
    }