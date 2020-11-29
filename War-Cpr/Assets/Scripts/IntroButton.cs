using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
    public AudioSource buttonPress;

    public void Confirm()
    {

        buttonPress.Play();
        LevelRedirect.redirectToLevel = 2;
        SceneManager.LoadScene(2);
    }
}
