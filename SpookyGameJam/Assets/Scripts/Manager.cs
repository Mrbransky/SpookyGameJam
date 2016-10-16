using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    bool canFinishLevel = false;

    public int maxIngredients;
    public int numberOfIngredientsPlaced = 0;

    void Update()
    {
        if(numberOfIngredientsPlaced >= maxIngredients)
        {
            canFinishLevel = true;
            //go to next scene
        }
    }
}
