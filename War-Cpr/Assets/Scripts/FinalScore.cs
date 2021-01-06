using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{

    public Text text;
    public GameObject cvs;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "SCORE : " + PlayerPrefs.GetFloat("FinalScore").ToString()+"%";
        StartCoroutine(FadeSceneTransition());
    }



    IEnumerator FadeSceneTransition()
    {
        yield return new WaitForSeconds(7);
        cvs.SetActive(true);
        yield return new WaitForSeconds(2);
        Application.Quit();
    }

}
