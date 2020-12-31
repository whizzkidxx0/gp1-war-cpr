using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HeartMassage : MonoBehaviour
{
    public GameObject hand;
    public static bool playHandAnimHeartMassage = false;
    public static float totalTimeHeartMassage = 18;
    public Text text;
    private float seconds;
    public GameObject cube;
    public GameObject childCube;
    public GameObject canvas;
    public AudioSource playNext;
    //public GameObject twoHands;
    public static bool startTimerHeartMassage = false;
    public GameObject txt;
    public GameObject heartCube;
    public GameObject centerHeartCube;
    public GameObject mouthCube;
    public GameObject lips;
    public static bool nextStepHeartMassage = false;
    public static bool cubeParentInteract = false;
    //public Text counterText;
    //public GameObject counterCanvas;

    public void PlayHeartMassage()
    {
        //counterCanvas.SetActive(true);
        cubeParentInteract = true;
        startTimerHeartMassage = true;
        if (playHandAnimHeartMassage == false)
        {
            hand.SetActive(false);
            hand.GetComponent<Animation>().Stop("cprHintAnim");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (startTimerHeartMassage)
        {
            txt.SetActive(true);
            totalTimeHeartMassage -= Time.deltaTime;
            seconds = (int)(totalTimeHeartMassage % 60);


            if (seconds <= 0)
            {
                cube.SetActive(false);
                childCube.SetActive(false);
                canvas.SetActive(false);
                text.text = "NEXT STEP";
                nextStepHeartMassage = true;
                hand.GetComponent<Animation>().Stop("cprHintAnim");
                hand.SetActive(false);
                startTimerHeartMassage = false;
            }
            else
            {
                hand.SetActive(false);
                hand.GetComponent<Animation>().Stop("cprHintAnim");
                text.text = seconds.ToString();
                playHandAnimHeartMassage = true;
            }

        }


        if (nextStepHeartMassage)
        {
            if (playNext.isPlaying == false)
            {
                StartCoroutine(playNextScene());
            }
        }

    }


    IEnumerator playNextScene()
    {
        playNext.Play();
        yield return new WaitForSeconds(3);
        playNext.Stop();
        LipsCollision.totalTimeLip = 5;
        nextStepHeartMassage = false;
        yield return new WaitForSeconds(.1f);
        //playCprHeartMassage.Play();
        //yield return new WaitForSeconds(10f);
        //twoHands.SetActive(true);
        //twoHands.GetComponent<Animation>().Play("cprHintAnim");
        //heartCube.SetActive(true);
        //centerHeartCube.SetActive(true);
        mouthCube.SetActive(true);
        lips.SetActive(true);
        //counterTextCanvas.SetActive(true);
        heartCube.SetActive(false);
        centerHeartCube.SetActive(false);
        //startTimer = true;
    }
}
