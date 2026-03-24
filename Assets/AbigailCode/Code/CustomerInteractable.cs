using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CustomerInteractable : MonoBehaviour, IInteractable
{
    public bool IsTalking {  get; private set; }
    public bool InRange {  get; private set; }
    public string CustomerID {  get; private set; }

    public bool CanInteract()
    {
        return !IsTalking && InRange;
    }

    public void Interact()
    {
        if (!CanInteract()) return;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CustomerID ??= GlobalHelper.GenerateUniqueID(gameObject);
    }

    private void CutsomerTalking()
    {
        SetTalked(true);
    }

    public void SetTalked(bool talked)
    {
        IsTalking = talked;
    }
}
