using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CustomerInteractable : MonoBehaviour, IInteractable
{
    public bool IsTalking {  get; private set; }

    public string CustomerID {  get; private set; }
    public bool CanInteract()
    {
        throw new System.NotImplementedException();
    }

    public void Interact()
    {
        throw new System.NotImplementedException();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
}
