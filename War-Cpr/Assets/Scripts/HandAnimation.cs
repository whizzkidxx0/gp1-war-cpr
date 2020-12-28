using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimation : MonoBehaviour
{
    public GameObject hand;

    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(AnimationStart());
    }

    IEnumerator AnimationStart()
    {
        Test.startTimer = false;
        Test.totalTime = 5;
        hand.SetActive(true);
        yield return new WaitForSeconds(1);
        hand.GetComponent<Animation>().Play("NewHandAnim");
    }

}
