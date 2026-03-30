using UnityEngine;
public class Curse : MonoBehaviour
{
    public int curseValue;
    public void OnValidate()
    {
        if (curseValue < 0)
        {
            curseValue = 4;
        }
        if (curseValue > 4)
        {
            curseValue = 0;
        }
    }
    void Update()
    {
        if (curseValue < 0)
        {
            curseValue = 4;
        }
        if (curseValue > 4)
        {
            curseValue = 0;
        }
    }


}
