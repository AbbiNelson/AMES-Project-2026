using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ItemSlot : MonoBehaviour, IDropHandler
{
    public bool canDrag = true;
    public int slotAmount;
    public bool allowMaterials = true;
    public bool persistant = false;
    static Item item;

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
            item = draggableItem.item;
        }
    }
    public void Start()
    {
        if (item != null && persistant)
        {
            GameObject newItemObj = new GameObject(item.name);
            newItemObj.AddComponent<Image>().sprite = item.Icon;
            newItemObj.AddComponent<DraggableItem>().item = item;
            newItemObj.transform.SetParent(transform, false);
        }
    }

}
