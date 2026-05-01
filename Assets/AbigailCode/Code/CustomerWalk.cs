using UnityEngine;
using UnityEngine.InputSystem;

public class CustomerWalk : MonoBehaviour
{
    public Vector2 pointA;
    public Vector2 pointB;
    public float speed = 1.0f;
    private CustomerInteractable customerInteractable;
    private Vector2 currentTarget;
    private RectTransform rt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        customerInteractable = GetComponent<CustomerInteractable>();
        rt = GetComponent<RectTransform>();
    }
    
    void Start()
    {
        currentTarget = pointB;
    }

    // Update is called once per frame
    void Update()
    {
        rt.anchoredPosition = Vector3.MoveTowards(rt.anchoredPosition, currentTarget, speed * Time.deltaTime);

        if(rt.anchoredPosition == currentTarget)
        {
            if (currentTarget == pointA)
            {
                currentTarget = pointB;
                
            }
            
        }
    }
}
