﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelRedirect : MonoBehaviour
{

    public static int redirectToLevel;
    public static int nextLevel;


    // Update is called once per frame
    void Update()
    {
        
        if(redirectToLevel == 2)
        {
            SceneManager.LoadScene(redirectToLevel);
        }


    }
}
