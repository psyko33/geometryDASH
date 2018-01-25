using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuePause : MonoBehaviour {

    public GameObject menuePause;
    public Button Pause;
    public GameObject MenuFin;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}
    public void MenuePauseActive ()
    {
        menuePause.SetActive(true);
        Time.timeScale = 0;
    }
    public void MenuePauseNotActive ()
    {
        menuePause.SetActive(false);
        Time.timeScale = 1;
    }
    public void LoadSceneQuentin ()
    {
        SceneManager.LoadScene("Quentin");
    }
    public void CanvasEnd()
    {
        MenuFin.SetActive(true);
        Pause.interactable = false;
    }
}
