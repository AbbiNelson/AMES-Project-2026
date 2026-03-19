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
            yield return new WaitForSeconds(interval);

            GameObject newCustomer = Instantiate
            (
                Customer,
                customerSpawnpoint.position,
                customerSpawnpoint.rotation
            );
        }

    }
}
