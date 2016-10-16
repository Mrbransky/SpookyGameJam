using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MenuNav : MonoBehaviour {


    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadCredits()
    {
        //SceneManager.LoadScene()
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
