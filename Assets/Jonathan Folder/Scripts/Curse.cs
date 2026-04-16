using AYellowpaper.SerializedCollections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Curse : MonoBehaviour
{
    public SerializedDictionary<Curses.CurseType, Curses> dictonary;
    public Curses curse;
    public Image curseHolder;

    private Curses.CurseType valueCurse;

    public void CurseUp()
    {
        valueCurse++;
        if(valueCurse > Curses.CurseType.Sluggish)
        {
            valueCurse = Curses.CurseType.Fragility;
        }

        curse = dictonary[valueCurse];
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

        curse = dictonary[valueCurse];

        Debug.Log(valueCurse);
    }
    public void DoCurse()
    {
        Curses applyCurse = curse;
        Debug.Log("Applied " );
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
