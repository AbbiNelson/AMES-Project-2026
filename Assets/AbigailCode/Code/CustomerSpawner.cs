using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CustomerSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject customerPrefab;
    [SerializeField]
    private float customerInterval = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(customerSpawner(customerInterval, customerPrefab));  
    }

    // Update is called once per frame
    private IEnumerator customerSpawner(float interval, GameObject Customer)
    {
        yield return new WaitforSeconds(interval);
        GameObject newCustomer = Instantiate(Customer, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(customerSpawner(interval, Customer));
    }
}
