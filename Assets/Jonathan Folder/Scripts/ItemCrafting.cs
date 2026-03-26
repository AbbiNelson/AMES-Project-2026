using NUnit.Framework;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ItemCrafting : MonoBehaviour
{
    public ItemSlot[] Slots;
    public ItemSlot ResultSlot;

    public void CraftInSlots()
    {
        //get draggable item in each slot, get the item from it, and pass it to Craft
        Item newItem = Craft(Slots.Select(slot => slot.GetComponentInChildren<DraggableItem>().item).ToArray());
        
        if (newItem != null)
        {
            foreach (ItemSlot slot in Slots)
            {
                Destroy(slot.transform.GetChild(0).gameObject);
            }

            GameObject newItemObj = new GameObject(newItem.name);
            newItemObj.AddComponent<Image>().sprite = newItem.Icon;
            newItemObj.AddComponent<DraggableItem>().item = newItem;

            newItemObj.transform.SetParent(ResultSlot.transform, false);
        }
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
