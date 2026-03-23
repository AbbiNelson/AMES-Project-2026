using UnityEngine;

[CreateAssetMenu(fileName = "CurseRecipe", menuName = "Scriptable Objects/CurseRecipe")]
public class CurseRecipe : ScriptableObject
{
    public Curse[] curseingredients;
    public Curse output;
}
