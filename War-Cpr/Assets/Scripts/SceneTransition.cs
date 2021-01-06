using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HeartMassage.playHandAnimHeartMassage = false;
        HeartMassage.nextStepHeartMassage = false;
        HeartMassage.totalTimeHeartMassage = 18;
        HeartMassage.startTimerHeartMassage = false;
        HeartMassage.cubeParentInteract = false;
        HeartMassage.sceneCounter = 0;
        Test.totalTime = 5;
        Test.playHandAnim = false;
        Test.startTimer = false;
        Test.nextStep = false;
        ChildCubeInterract.childCubeInterract = false;
        ChildCubeInterract.counter = 0;
        ChildCubeInterract.counter2 = 0;
        PlayerPrefs.SetFloat("FinalScore", 0);
        PlayerPrefs.SetInt("SecondScore", 0);

        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(74);
        LevelRedirect.redirectToLevel = 2;
        SceneManager.LoadScene(8);
    }

}
