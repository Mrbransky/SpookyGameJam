using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour {

    [SerializeField]
    int countdownTime;
    [SerializeField]
    Text countdownText;

    // Use this for initialization
    void Start () {

        InvokeRepeating("decrease", 1.0f, 1.0f);
	
	}
	
	// Update is called once per frame
	void Update () {
        if (countdownTime >= 0)
        {
            countdownText.text = countdownTime.ToString();
            if (countdownTime <= 5)
            {
                countdownText.color = Color.red;
            }
        }
        else
        {
            GameObject.Find("IngredientText").GetComponent<IngredientText>().LoseMessage();
            gameObject.SetActive(false);

        }

    }

    void decrease()
    {
        countdownTime -= 1;
    }

    public void increaseTime(int seconds)
    {
        countdownTime += seconds;
    }

    public void decreaseTime(int seconds)
    {
        countdownTime -= seconds;
    }

   }
