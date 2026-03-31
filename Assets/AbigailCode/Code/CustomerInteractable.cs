using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class CustomerInteractable : MonoBehaviour, IInteractable
{
    public string[] lines;

    public bool IsTalking {  get; private set; }
    public string CustomerID {  get; private set; }
    private Interact interactScript;

    void Awake()
    {
        interactScript = FindFirstObjectByType<Interact>(FindObjectsInactive.Include);
    }
     
    
    public bool CanInteract()
    {
        return !IsTalking;
    }

    public void OnInteract()
    {
        if (!CanInteract()) return;

        Debug.Log("PLEASE WORK!!!!!");
        Interact.Lines = lines;

        interactScript.gameObject.SetActive(true);
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
