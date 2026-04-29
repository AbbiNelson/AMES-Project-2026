using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class CustomerInteractable : MonoBehaviour, IInteractable
{
    public Customer customer;
    
    public bool IsTalking {  get; private set; }
    public string CustomerID {  get; private set; }
    private Dialogue interactScript;
    public Item chosen;

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
        Dialogue.Lines = customer.lines.Select(line => string.Format(line, chosen.name)).ToArray();

        interactScript.gameObject.SetActive(true);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CustomerID ??= GlobalHelper.GenerateUniqueID(gameObject);

        if(CustomerSpawner.wantedItem == null)
        {
            int number = Random.Range(0, 4);
            chosen = customer.items[number];
            CustomerSpawner.wantedItem = chosen;
        }
        else
        {
            chosen = CustomerSpawner.wantedItem;
        }
    }

    public void giveItem(Item item)
    {
        if(item == chosen)
        {

        }
        else
        {

        }

        CustomerSpawner.wantedItem = null;
        GetComponent<CustomerWalk>().currentTarget = GetComponent<CustomerWalk>().pointA;
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
