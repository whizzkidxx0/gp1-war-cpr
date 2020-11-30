using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Rollcredits());
    }


    IEnumerator Rollcredits()
    {
        yield return new WaitForSeconds(28f);
        SceneManager.LoadScene(2);

    }
}
