using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    public int maxIngredients;
    public int numberOfIngredientsPlaced = 0;

    void Update()
    {
        if(numberOfIngredientsPlaced >= maxIngredients)
        {
            //go to next scene
        }
    }
}
