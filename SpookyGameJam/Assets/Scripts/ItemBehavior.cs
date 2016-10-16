using UnityEngine;
using System.Collections;

public class ItemBehavior : MonoBehaviour
{

    public bool isCorrectIngredient;
    ParticleSystem splash;
    public Vector2 startPos;
    public bool isPickedUp = false;
    Manager manager;
    [SerializeField]
    int timerIncrease;

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
                GameObject.Find("CountdownTimer").GetComponent<Countdown>().increaseTime(timerIncrease);
                splash.Play();
            }
            else
            {
                manager.resetItems();
                transform.position = startPos;
            }
        }
    }
}
