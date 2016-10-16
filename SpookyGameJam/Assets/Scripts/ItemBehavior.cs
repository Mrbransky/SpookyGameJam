using UnityEngine;
using System.Collections;

public class ItemBehavior : MonoBehaviour
{

    public bool isCorrectIngredient;
    public bool isNegativeIngredient;
    ParticleSystem splash;
    public Vector2 startPos;
    public bool isPickedUp = false;
    Manager manager;

    void Start()
    {
        startPos = transform.position;
        splash = GameObject.Find("Splash").GetComponent<ParticleSystem>();
        manager = GameObject.Find("GameManager").GetComponent<Manager>();
    }
    void Update()
    {
        if (!isPickedUp)
        {
            transform.parent = null;
            GetComponent<Collider2D>().enabled = true;
        }
        else
        {
            GetComponent<Collider2D>().enabled = false;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Cauldron")
        {
            if (isCorrectIngredient)
            {
                gameObject.SetActive(false);
                manager.numberOfIngredientsPlaced += 1;
                GameObject.Find("CountdownTimer").GetComponent<Countdown>().increaseTime(5);
                GameObject.Find("IngredientText").GetComponent<IngredientText>().CorrectMessage();
                splash.Play();
            }
            else
            {
                if (isNegativeIngredient)
                {
                    GameObject.Find("CountdownTimer").GetComponent<Countdown>().decreaseTime(1);
                    GameObject.Find("IngredientText").GetComponent<IngredientText>().BadIngredient();
                }

                else
                    GameObject.Find("IngredientText").GetComponent<IngredientText>().IncorrectMessage();
                manager.resetItems();
                manager.numberOfIngredientsPlaced = 0;
                transform.position = startPos;
            }

            if (manager.numberOfIngredientsPlaced == manager.maxIngredients)
                GameObject.Find("IngredientText").GetComponent<IngredientText>().WinMessage();

        }
    }
}
