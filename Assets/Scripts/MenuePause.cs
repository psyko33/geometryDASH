using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuePause : MonoBehaviour {

    public GameObject menuePause; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        MenuePauseActive();
        MenuePauseNotActive();
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
}
