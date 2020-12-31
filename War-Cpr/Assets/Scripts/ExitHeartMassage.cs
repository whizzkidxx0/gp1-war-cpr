using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ExitHeartMassage : MonoBehaviour
{
    public GameObject hand;
    public GameObject timerText;
    public Text counterText;

    public void ExitMassage()
    {
        HeartMassage.cubeParentInteract = false;
        StartCoroutine(AnimationStart());


        if (!HeartMassage.cubeParentInteract)
        {
            ChildCubeInterract.counter = 0;
            counterText.text = ChildCubeInterract.counter.ToString();
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
