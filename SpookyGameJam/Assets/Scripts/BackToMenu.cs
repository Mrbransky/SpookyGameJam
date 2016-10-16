using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {

	public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
