using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Item item;
    private Image image;
    public bool trashable = true;

    [HideInInspector] public Transform parentAfterDrag;

    void Awake()
    {
        image = GetComponent<Image>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Started dragging " + gameObject.name);
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Stopped dragging " + gameObject.name);
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }

    void Start()
    {
        if (item != null)
        {
            image.sprite = item.Icon;
            image.enabled = true;
        }
    }

    void OnValidate()
    {
        if (item != null)
        {
            image.sprite = item.Icon;
            image.enabled = true;
        }
    }
}
