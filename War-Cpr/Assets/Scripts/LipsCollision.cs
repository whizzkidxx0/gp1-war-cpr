using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LipsCollision : MonoBehaviour
{
    public static float totalTimeLip = 5;
    public Text text;
    private float seconds;
    //public GameObject txt;
    public GameObject canvas;
    bool startTimerLip = false;
    bool nextStepLip = false;
    //public GameObject timerText;
    public GameObject mouth;
    public GameObject lips;
    public AudioSource blowAir;
    public AudioSource playCprHeartMassage;
    public GameObject twoHands;
    public GameObject lipObj;
    public GameObject mouthObj;
    public GameObject heartCube;
    public GameObject centerHeartCube;
    public GameObject counterTextCanvas;
    public GameObject counterTextCanvas2;
    public static bool showScore = false;




    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "mouth")
        {
            startTimerLip = true;
            HeartMassage.sceneCounter = 1;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "mouth")
        {
           AnimationStart();
           HeartMassage.sceneCounter = 1;

        }
    }


    // Start is called before the first frame update
    void Start()
    {
       // HeartMassage.sceneCounter = 0;
        HeartMassage.sceneCounter = 1;

    }


    // Update is called once per frame
    void Update()
    {
            if (startTimerLip)
            {
                canvas.SetActive(true);
                totalTimeLip -= Time.deltaTime;
                seconds = (int)(totalTimeLip % 60);

                if (blowAir.isPlaying == false)
                {
                    blowAir.Play();
                }


                if (seconds <= 0)
                {
                    lipObj.SetActive(false);
                    mouthObj.SetActive(false);
                    lips.SetActive(false);
                    mouth.SetActive(false);
                    canvas.SetActive(false);
                    nextStepLip = true;
                    //text.text = "NEXT STEP";

                    if (nextStepLip)
                    {
                        //nextStepLip = true;
                        seconds = 0;
                        startTimerLip = false;
                        blowAir.Stop();
                        HeartMassage.sceneCounter = 1;
                        HeartMassage.totalTimeHeartMassage = 18;
                        ChildCubeInterract.counter = 0;
                        ChildCubeInterract.counter2 = 0;
                        //canvas.SetActive(true);
                        if (playCprHeartMassage.isPlaying == false)
                        {
                            playCprHeartMassage.Play();
                        }
                        //yield return new WaitForSeconds(2f);
                        StartCoroutine(Pause());
                        twoHands.SetActive(true);
                        twoHands.GetComponent<Animation>().Play("cprHintAnim");
                        startTimerLip = false;
                        heartCube.SetActive(true);
                        centerHeartCube.SetActive(true);
                        //counterTextCanvas.SetActive(true);
                        lipObj.SetActive(false);
                        mouthObj.SetActive(false);
                        StartCoroutine(Pause2());
                        showScore = true;
                        //nextStepLip = false;           
                    }
                }
                else
                {
                    text.text = seconds.ToString();
                }
            }

            else
            {
                if (blowAir.isPlaying == true)
                {
                    blowAir.Stop();
                }
            }
        

         //if (nextStepLip)
         //{
         // // if (playCprHeartMassage.isPlaying == false)
         // // {
         //       StartCoroutine(playNextScene2());
         // // }
         //}
    }


    IEnumerator Pause()
    {
        yield return new WaitForSeconds(3);
    }

    IEnumerator Pause2()
    {
        yield return new WaitForSeconds(.5f);
    }


    //IEnumerator playNextScene2()
    //{
    //    HeartMassage.sceneCounter = 1;
    //    HeartMassage.totalTimeHeartMassage = 18;
    //    ChildCubeInterract.counter = 0;
    //    txt.SetActive(true);
    //    playCprHeartMassage.Play();
    //    nextStepLip = false;
    //    yield return new WaitForSeconds(2f);
    //    twoHands.SetActive(true);
    //    twoHands.GetComponent<Animation>().Play("cprHintAnim");
    //    heartCube.SetActive(true);
    //    centerHeartCube.SetActive(true);
    //    counterTextCanvas.SetActive(true);
    //    lipObj.SetActive(false);
    //    mouthObj.SetActive(false);
    //    //startTimer = true;
    //}



    public void AnimationStart()
    {

        if (nextStepLip == false)
        {
            startTimerLip = false;

            if (startTimerLip == false)
            {
                canvas.SetActive(false);
            }
            totalTimeLip = 5;
        }
    }
}

