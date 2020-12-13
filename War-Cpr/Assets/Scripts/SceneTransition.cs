using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(74);
        LevelRedirect.redirectToLevel = 2;
        SceneManager.LoadScene(8);
    }

}
