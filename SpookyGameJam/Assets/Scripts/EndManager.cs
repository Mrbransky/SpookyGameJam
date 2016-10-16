using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EndManager : MonoBehaviour {


    public void EndGame()
    {
        Application.Quit();
    }
    public void StartGameAgain()
    {
        SceneManager.LoadScene(0);
    }
}
