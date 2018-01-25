using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEnd : MonoBehaviour {

    public Button Pause;
    public GameObject MenuFin;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        MenuFin.SetActive(true);
        Pause.interactable = false;
        Time.timeScale = 0;
    }
}
