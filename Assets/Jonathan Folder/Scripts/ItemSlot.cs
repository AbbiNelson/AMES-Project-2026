using UnityEngine;
using UnityEngine.EventSystems;
public class ItemSlot : MonoBehaviour, IDropHandler
{
    public bool canDrag = true;

    public void OnDrop(PointerEventData eventData)
    {
        if(!canDrag)
        {
            return;
        }

        if (transform.childCount == 0)
        {
            GameObject droppedItem = eventData.pointerDrag;
            DraggableItem draggableItem = droppedItem.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;
        }
    }

}
