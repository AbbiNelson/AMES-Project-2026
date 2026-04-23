using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject customerPrefab;
    [SerializeField]
    private float customerInterval = 5.0f;
    [SerializeField]
    private Transform customerSpawnpoint;

    [SerializeField]
    private Customer[] customers;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(customerSpawner(customerInterval, customerPrefab)); 
        
    }

    // Update is called once per frame
    private IEnumerator customerSpawner(float interval, GameObject Customer)
    {
        while (true)
        {
            GameObject newCustomer = Instantiate
            (
                Customer,
                customerSpawnpoint.position,
                customerSpawnpoint.rotation
            );

            newCustomer.GetComponent<CustomerInteractable>().customer = customers[Random.Range(0, customers.Length)];

            yield return new WaitForSeconds(1f);
            yield return new WaitUntil(() => FindObjectsByType<CustomerWalk>(FindObjectsSortMode.None).Length == 0);
        }

    }
}
