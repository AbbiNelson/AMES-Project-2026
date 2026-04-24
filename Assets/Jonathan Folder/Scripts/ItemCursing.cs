using AYellowpaper.SerializedCollections;
using UnityEngine;

public class ItemCursing : MonoBehaviour
{
    public SerializedDictionary<Curses.CurseType, Curses> Cdictonary;
    public Curses curse;
    public SerializedDictionary<ItemCrafting.ItemType, Item> Idictonary;
    public ItemSlot itemslot;

    public void DoCurse()
    {
        Curses applyCurse = curse;
        Debug.Log("Applied " + curse + " to " + itemslot.GetComponentInChildren<DraggableItem>().item);
    }
   
}
