using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IngredientText : MonoBehaviour
{

    [SerializeField]
    Canvas messageCanvas;
    [SerializeField]
    Text ingredientText;
    [SerializeField]
    string witchMsgLine1;

    private string str;


    // Use this for initialization
    void Start()
    {
        messageCanvas.enabled = false;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3.0f);
        TurnOffMessage();
    }

    public void CorrectMessage()
    {
        str = "That's the right ingredient, You have been so obedient!";
        TurnOnMessage();
    }

    public void IncorrectMessage()
    {
        str = "You have to remake the potion, I'm starting to doubt your devotion!";
        TurnOnMessage();
    }

    public void WinMessage()
    {
        str = witchMsgLine1;
        TurnOnMessage();
    }

    public void LoseMessage()
    {
        str = "You didn't manage to make my brew, I guess I'll just make Corgi stew!";
        TurnOnMessage();
    }

    public void BadIngredient()
    {
        str = "WHAT HAVE YOU DONE?! It's completely spoiled! I'm reducing your time, you'll soon be boiled!";
        TurnOnMessage();
    }


    void TurnOnMessage()
    {
        ingredientText.text = str;
        messageCanvas.enabled = true;
        StartCoroutine(Wait());
    }

    private void TurnOffMessage()
    {
        messageCanvas.enabled = false;
    }
}
