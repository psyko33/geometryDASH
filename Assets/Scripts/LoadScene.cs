using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public void LoadAddOnClick()
    {
        SceneManager.LoadScene("Mikael");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
