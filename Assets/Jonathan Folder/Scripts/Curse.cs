using AYellowpaper.SerializedCollections;
using Unity.VisualScripting;
using UnityEngine;

public class Curse : MonoBehaviour
{
    public SerializedDictionary<Curses.CurseType, Curses> dictonary;
    public Curses curse;

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
    public void Update()
    {
   /*  if (valueCurse = 0)      
     {
          //set the curse holder to the new frail sprite
     }
     else if (valueCurse = 1)
     {
          //set the curse holder to the new heavy sprite
     }
     else if (valueCurse = 2)
     {
          //set the curse holder to the new large sprite
     }
     else if (valueCurse = 3)
     {
          //set the curse holder to the new small sprite
     }
     else if (valueCurse = 4)
     {
          //set the curse holder to the new sluggish sprite
     }*/
    }

}
