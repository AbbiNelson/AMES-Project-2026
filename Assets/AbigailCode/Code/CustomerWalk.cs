using UnityEngine;
using UnityEngine.InputSystem;

public class CustomerWalk : MonoBehaviour
{
    public Vector3 pointA;
    public Vector3 pointB;
    public float speed = 1.0f;
    private CustomerInteractable customerInteractable;
    public Vector3 currentTarget;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        customerInteractable = GetComponent<CustomerInteractable>(); 
        currentTarget = pointA;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        if(transform.position == currentTarget)
        {
            if (currentTarget == pointA)
            {
                currentTarget = pointB;
                
            }
            
        }

        if (transform.position == pointB && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);

            if (hit && hit.collider.gameObject == gameObject)
            {
                customerInteractable.OnInteract();
            }
        }
    }
}
