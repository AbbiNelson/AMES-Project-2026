using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class CustomerInteractable : MonoBehaviour, IInteractable
{
    public bool IsTalking {  get; private set; }
    public string CustomerID {  get; private set; }
    public Interact interactScript;
    public GameObject DialogueSystemGameObject;
    public bool CanInteract()
    {
        return !IsTalking;
    }

    public void Interact()
    {
        if (!CanInteract()) return;

        interactScript = GetComponent<Interact>();
        DialogueSystemGameObject.SetActive(true);
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
