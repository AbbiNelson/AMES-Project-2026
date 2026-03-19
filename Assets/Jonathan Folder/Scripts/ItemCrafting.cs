using NUnit.Framework;
using System;
using System.Linq;
using UnityEngine;

public class ItemCrafting : MonoBehaviour
{
    public Item[] items;

    void Start()
    {
        Item newItem = Craft(items);
        Debug.Log("Crafted item: " + newItem.name);
    }

    public Item Craft(Item[] items)
    {
        Recipe[] recipes = Resources.LoadAll<Recipe>("Recipes");
        
        foreach (Recipe recipe in recipes)
        {
            if (CheckIngredients(items, recipe.ingredients))
            {
                return recipe.output;
            }
        }

        return null;
    }

    private bool CheckIngredients(Item[] items, Item[] ingredients)
    {
        if (items.Length != ingredients.Length)
        {
            return false;
        }

        for (int i = 0; i < items.Length; ++i)
        {
            if (items[i] != ingredients[i])
            {
                 return false;
            }
        }

        return true;
    }
}
