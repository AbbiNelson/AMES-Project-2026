using UnityEngine;

public class CurseCrafting : MonoBehaviour
{
    public Curse[] curses;

    void Start()
    {
        Curse newCurse = Craft(curses);
        Debug.Log("Crafted curse: " + newCurse.name);
    }

    public Curse Craft(Curse[] curses)
    {
        CurseRecipe[] curserecipes = Resources.LoadAll<CurseRecipe>("CurseRecipes");

        foreach (CurseRecipe curserecipe in curserecipes)
        {
            if (CheckCurseIngredients(curses, curserecipe.curseingredients))
            {
                return curserecipe.output;
            }
        }

        return null;
    }

    private bool CheckCurseIngredients(Curse[] curses, Curse[] curseingredients)
    {
        if (curses.Length != curseingredients.Length)
        {
            return false;
        }

        for (int i = 0; i < curses.Length; ++i)
        {
            if (curses[i] != curseingredients[i])
            {
                return false;
            }
        }

        return true;
    }
}