﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{

    public AudioSource buttonPress;

    public void PlayGame() {

        buttonPress.Play();
        LevelRedirect.redirectToLevel = 2;
        SceneManager.LoadScene(3);
    }








}
