using UnityEngine;
using System.Collections;

public class ItemBehavior : MonoBehaviour
{

    public bool isCorrectIngredient;
    ParticleSystem splash;
    Vector2 startPos;
    public bool isPickedUp = false;
    [SerializeField]
    int timerIncrease;

    void Start()
    {
        startPos = transform.position;
        splash = GameObject.Find("Splash").GetComponent<ParticleSystem>();
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
                Destroy(gameObject);
                GameObject.Find("GameManager").GetComponent<Manager>().numberOfIngredientsPlaced += 1;
                GameObject.Find("CountdownTimer").GetComponent<Countdown>().increaseTime(timerIncrease);
                splash.Play();
            }
            else
            {
                transform.position = startPos;
            }
        }
    }
}
