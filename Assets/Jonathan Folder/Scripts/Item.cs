using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    public Sprite Icon;
    public bool IsCursed;
   // public 
    public bool isMaterial;

}
