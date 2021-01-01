using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExitHeartMassage : MonoBehaviour
{
    public GameObject hand;
    public GameObject timerText;
    public Text counterText;
    public Text counterText2;


    public void ExitMassage()
    {
        HeartMassage.cubeParentInteract = false;
        StartCoroutine(AnimationStart());


        if (!HeartMassage.cubeParentInteract)
        {
            if (HeartMassage.sceneCounter == 1)
            {
                ChildCubeInterract.counter = 0;
                counterText.text = ChildCubeInterract.counter.ToString();
            }
            else if (HeartMassage.sceneCounter == 0)
            {
                ChildCubeInterract.counter2 = 0;
                counterText2.text = ChildCubeInterract.counter2.ToString();
            }
        }
    }

    IEnumerator AnimationStart()
    {
        if (HeartMassage.nextStepHeartMassage == false)
        {
            HeartMassage.startTimerHeartMassage = false;

            if (HeartMassage.startTimerHeartMassage == false)
            {
                timerText.SetActive(false);
            }

            HeartMassage.totalTimeHeartMassage = 18;
            yield return new WaitForSeconds(.2f);

            if (HeartMassage.playHandAnimHeartMassage)
            {
                hand.SetActive(true);
                hand.GetComponent<Animation>().Play("cprHintAnim");
            }
        }
    }
}
