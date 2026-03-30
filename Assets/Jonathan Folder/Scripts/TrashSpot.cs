using System.Linq;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class TrashSpot : MonoBehaviour
{
    public ItemSlot[] Slots;

    public void DeleteSlot()
    {
        Slots.Select(slot => slot.GetComponentInChildren<DraggableItem>().item).ToArray();
    
        if (Slots.Select(slot => slot.GetComponentInChildren<DraggableItem>().item).ToArray().Length > 0)
            foreach (ItemSlot slot in Slots)
            {
                 Destroy(slot.transform.GetChild(0).gameObject);
            }

           


    }
}
