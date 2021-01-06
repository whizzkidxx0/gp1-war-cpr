using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class datumtransition : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitForDateFade());
    }

    IEnumerator WaitForDateFade()
    {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene(2);

    }
}
