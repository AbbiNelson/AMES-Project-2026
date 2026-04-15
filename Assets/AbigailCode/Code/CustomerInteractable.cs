using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class CustomerInteractable : MonoBehaviour, IInteractable
{
    public Customer customer;
    
    public bool IsTalking {  get; private set; }
    public string CustomerID {  get; private set; }
    private Dialogue interactScript;
    public Recipe chosen;

    void Awake()
    {
        interactScript = FindFirstObjectByType<Dialogue>(FindObjectsInactive.Include);
    }

   

    public bool CanInteract()
    {
        return !IsTalking;
    }

    public void OnInteract()
    {
        if (!CanInteract()) return;

        Debug.Log("PLEASE WORK!!!!!");
        Dialogue.Lines = customer.lines;

        interactScript.gameObject.SetActive(true);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CustomerID ??= GlobalHelper.GenerateUniqueID(gameObject);
        int number = Random.Range(0, 4);
        chosen = customer.requests[number];
    }

    private void CutsomerTalking()
    {
        SetTalked(true);
    }

    public void SetTalked(bool talked)
    {
        IsTalking = talked;
    }

    public void TargetFunction()
    {
        Debug.Log("Check if working");
    }
}
