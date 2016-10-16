using UnityEngine;
using System.Collections;

public class ItemBehavior : MonoBehaviour {

    public bool isCorrectIngredient;
    Vector2 startPos;
    [SerializeField]
    int timerIncrease;

    void Start()
    {
        startPos = transform.position;
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
                }
                else
                {
                transform.position = startPos;
                }
            }
    }
}
