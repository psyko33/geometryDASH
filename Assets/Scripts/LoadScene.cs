﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour {

    public void LoadAddOnClick(int level)
    {
        Application.LoadLevelAdditive(level);
    }
}
