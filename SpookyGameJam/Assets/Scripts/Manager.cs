using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    bool canFinishLevel = false;

    public int maxIngredients;
    public int numberOfIngredientsPlaced = 0;
    public GameObject door;

    void Update()
    {
        if(numberOfIngredientsPlaced >= maxIngredients)
        {
            canFinishLevel = true;
            //go to next scene
        }
        if(canFinishLevel == true)
        {
            door.SetActive(true);
        }
    }
}
