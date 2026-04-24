using AYellowpaper.SerializedCollections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Curse : MonoBehaviour
{
    public SerializedDictionary<Curses.CurseType, Curses> Cdictonary;
    public Curses curse;
    public Image curseHolder;
    public SerializedDictionary<ItemCrafting.ItemType, Item> Idictonary;
    public ItemSlot itemslot;

    private Curses.CurseType valueCurse;

    public void CurseUp()
    {
        valueCurse++;
        if(valueCurse > Curses.CurseType.Sluggish)
        {
            valueCurse = Curses.CurseType.Fragility;
        }

        curse = Cdictonary[valueCurse];
        //set the curse holder to the new curse's sprite
        
        Debug.Log(valueCurse);
    }

    public void CurseDown()
    {
        valueCurse--;
        if(valueCurse < Curses.CurseType.Fragility)
        {
            valueCurse = Curses.CurseType.Sluggish;
        }

        curse = Cdictonary[valueCurse];

        Debug.Log(valueCurse);
    }
    public void DoCurse()
    {
        Curses applyCurse = curse;
        applyCurse.ApplyCurse(itemslot.GetComponentInChildren<DraggableItem>().item);
        Debug.Log("Applied " + curse + " to " + itemslot.GetComponentInChildren<DraggableItem>().item );
    }
    public void Update()
    {
        if (valueCurse == Curses.CurseType.Fragility)
        {
            curseHolder.sprite = curse.icon;
        }
        else if (valueCurse == Curses.CurseType.Heavy)
        {
            curseHolder.sprite = curse.icon;
        }
        else if (valueCurse == Curses.CurseType.Large)
        {
            curseHolder.sprite = curse.icon;
        }
        else if (valueCurse == Curses.CurseType.Small)
        {
            curseHolder.sprite = curse.icon;
        }
        else if (valueCurse == Curses.CurseType.Sluggish)
        {
            curseHolder.sprite = curse.icon;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            DoCurse();
        }
    }

    private void OnValidate()
    {
        if (valueCurse == Curses.CurseType.Fragility)
        {
            curseHolder.sprite = curse.icon;
        }
        else if (valueCurse == Curses.CurseType.Heavy)
        {
            curseHolder.sprite = curse.icon;
        }
        else if (valueCurse == Curses.CurseType.Large)
        {
            curseHolder.sprite = curse.icon;
        }
        else if (valueCurse == Curses.CurseType.Small)
        {
            curseHolder.sprite = curse.icon;
        }
        else if (valueCurse == Curses.CurseType.Sluggish)
        {
            curseHolder.sprite = curse.icon;
        }
    }

}
