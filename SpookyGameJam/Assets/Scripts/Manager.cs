using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    public bool canFinishLevel = false;

    public int maxIngredients;
    public int numberOfIngredientsPlaced = 0;
    public GameObject door;
    public GameObject[] items;
    void Start()
    {
        items = GameObject.FindGameObjectsWithTag("Ingredient");
    }
    void Update()
    {
        if(numberOfIngredientsPlaced >= maxIngredients)
        {
            canFinishLevel = true;
            door.transform.parent.GetComponent<Animator>().SetTrigger("doorOpen");
            //go to next scene
        }
        if(canFinishLevel == true)
        {
            door.SetActive(true);
        }
    }

    public void resetItems()
    {
        foreach(GameObject item in items)
        {
            item.transform.position = item.GetComponent<ItemBehavior>().startPos;
            item.SetActive(true);
        }
    }
}
