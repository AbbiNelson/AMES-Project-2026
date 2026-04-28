using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public List<Curses> Curse;
    public Item item;
    private Image image;
    public bool trashable = true;
    private Canvas canvas;
    private RectTransform rectTransform;

    [HideInInspector] public Transform parentAfterDrag;

    void Awake()
    {
        image = GetComponent<Image>();
        canvas = FindFirstObjectByType<Canvas>();
        rectTransform = GetComponent<RectTransform>();
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
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
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
