using UnityEngine;

[CreateAssetMenu(fileName = "Customer", menuName = "Scriptable Objects/Customer")]
public class Customer : ScriptableObject
{
    public GameObject prefab;
    public Item[] items;
    [TextArea] public string[] lines;
}