using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public void LoadAddOnClick()
    {
        SceneManager.LoadScene("Mikael");
        Time.timeScale = 1;
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
