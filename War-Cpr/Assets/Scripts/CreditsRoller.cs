using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CreditsRoller : MonoBehaviour
{

    public GameObject credits;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Rollcredits());
    }



    IEnumerator Rollcredits()
    {

        credits.SetActive(true);
        yield return new WaitForSeconds(20f);
        SceneManager.LoadScene(1);

    }



}
