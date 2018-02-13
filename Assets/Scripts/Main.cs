using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables
{
    public static int numberOfPickedCarrots = 0;
    public static Sprite[] basketSprites = new Sprite[5];
}

public class Main : MonoBehaviour
{
    public void Start()
    {
        for (int i=0; i < 5; i++)
        {
            GlobalVariables.basketSprites[i] = Resources.Load<Sprite>("Sprites/basket-carrot" + (i+1));
        }    
    }

}
