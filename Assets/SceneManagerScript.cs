using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

    public GameObject player;
	
	// Update is called once per frame
	void Update ()
    {
        if (player && player.transform.position.y < -4)
            YouDied();
    }

    public void PlayOnClick()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void YouDied()
    {
        SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
