using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            //endgame
            SceneManager.LoadScene(5);
            Debug.Log("End");
        }
    }
}
