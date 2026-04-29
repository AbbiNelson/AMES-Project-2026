using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CustomerSpawner : MonoBehaviour
{
    public static Customer current;
    public static Item wantedItem;

    [SerializeField]
    private float customerInterval = 5.0f;
    [SerializeField]
    private Transform customerSpawnpoint;

    [SerializeField]
    private Customer[] customers;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (current != null)
        {
            GameObject newcustomer = spawnCustomer(current);

            newcustomer.transform.position = Vector3.zero;
            var walk = newcustomer.GetComponent<CustomerWalk>();
            walk.currentTarget = walk.pointB;
        }

        StartCoroutine(customerSpawner(customerInterval)); 
    }

    // Update is called once per frame
    private IEnumerator customerSpawner(float interval)
    {
        while (true)
        {
            yield return new WaitUntil(() => FindObjectsByType<CustomerWalk>(FindObjectsSortMode.None).Length == 0);

            Customer customer = customers[Random.Range(0, customers.Length)];
            current = customer;

            spawnCustomer(customer);

            yield return new WaitForSeconds(1f);
        }

    }

    private GameObject spawnCustomer(Customer customer)
    {
        GameObject newCustomer = Instantiate
        (
            customer.prefab,
            customerSpawnpoint.position,
            customerSpawnpoint.rotation
        );

        return newCustomer;
    }
}
