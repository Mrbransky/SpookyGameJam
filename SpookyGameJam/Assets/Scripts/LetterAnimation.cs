using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LetterAnimation : MonoBehaviour {


    private string currText = "";
    [SerializeField]
    string[] rhymes;
    [SerializeField]
    float delay;
    [SerializeField]
    Canvas messageCanvas;
    [SerializeField]
    GameObject player;
    GameObject timer;

    void Start()
    {
        player = GameObject.Find("Player");
        timer = GameObject.Find("CountdownTimer");
      
        player.GetComponent<Movement>().enabled = false;
        messageCanvas.enabled = false;
        StartCoroutine(Wait());
        StartCoroutine(AnimateText());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.0f);
        messageCanvas.enabled = true;
    }

    IEnumerator AnimateText()
    {
        for (int j = 0; j < rhymes.Length; j++)
        {
            for (int i = 0; i < rhymes[j].Length; i++)
            {
                currText = rhymes[j].Substring(0, i + 1);
                this.GetComponent<Text>().text = currText;
                yield return new WaitForSeconds(delay);
            }
            yield return new WaitForSeconds(1.0f);
            currText = "";
        }

        messageCanvas.enabled = false;
        player.GetComponent<Movement>().enabled = true;
        timer.GetComponent<Countdown>().enabled = true;
    }


}
