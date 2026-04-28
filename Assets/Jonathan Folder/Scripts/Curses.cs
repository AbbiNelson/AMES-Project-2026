using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Curses", menuName = "Scriptable Objects/Curses")]
public class Curses : ScriptableObject
{
    public enum CurseType
    {
        Fragility,
        Heavy,
        Large,
        Small,
        Sluggish
    }
    public Sprite icon;
    public string description;

    internal void ApplyCurse(DraggableItem item)
    {
        item.Curse.Add(this);
    }
}
