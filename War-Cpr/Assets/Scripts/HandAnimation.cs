using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimation : MonoBehaviour
{
    public GameObject hand;
    public GameObject timerText;

    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(AnimationStart());
    }

    IEnumerator AnimationStart()
    {
        if (Test.nextStep == false)
        {
            Test.startTimer = false;

            if (Test.startTimer == false)
            {
                timerText.SetActive(false);
            }

            Test.totalTime = 5;
            yield return new WaitForSeconds(.2f);

            if (Test.playHandAnim)
            {
                hand.SetActive(true);
                hand.GetComponent<Animation>().Play("NewHandAnim");
            }
        }
        
    }

}
