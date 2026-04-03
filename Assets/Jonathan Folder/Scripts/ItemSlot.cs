using UnityEngine;
using UnityEngine.EventSystems;
public class ItemSlot : MonoBehaviour, IDropHandler
{
    public bool canDrag = true;
    public int slotAmount;
    public bool allowMaterials = true;
    public void OnDrop(PointerEventData eventData)
    {
        if (allowMaterials == false)
        {
            GameObject droppedItem = eventData.pointerDrag;
            DraggableItem draggableItem = droppedItem.GetComponent<DraggableItem>();
            if (draggableItem.item.isMaterial == true)
            {
                return;
            }
        }
        if(!canDrag)
        {
            return;
        }

        if (transform.childCount <= slotAmount)
        {
            GameObject droppedItem = eventData.pointerDrag;
            DraggableItem draggableItem = droppedItem.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;
        }
    }

}
