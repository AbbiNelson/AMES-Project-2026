using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
   // public  ItemType;
    public Sprite Icon;
    public bool IsCursed;
    public bool isMaterial;

}
