using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test : MonoBehaviour
{
    public static float totalTime = 5;
    public Text text;
    private float seconds;
    public GameObject hand;
    public GameObject txt;
    public static bool playHandAnim = false;
    private Animation anim;
    public static bool startTimer = false;
    public static bool nextStep = false;
    public GameObject cube;
    public GameObject canvas;
    public AudioSource playNext;
    public AudioSource playCprHeartMassage;
    public GameObject twoHands;
    public GameObject heartCube;
    public GameObject centerHeartCube;
    public GameObject counterTextCanvas;
    public GameObject counterTextCanvas2;
    public GameObject onNeckExit;
    public GameObject test;
    int counter = 0;
    public AudioSource timerTik;
    // Start is called before the first frame update
    public void PlayAnim()
    {
        startTimer = true;
        if (playHandAnim == false)
        {
            hand.SetActive(false);
            hand.GetComponent<Animation>().Stop("NewHandAnim");
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {

            if (timerTik.isPlaying == false)
            {

                timerTik.Play();
            }


            txt.SetActive(true);
                totalTime -= Time.deltaTime;
                seconds = (int)(totalTime % 60);


            if (seconds <= 0)
                {
                    cube.SetActive(false);
                    canvas.SetActive(false);
                    //text.text = "NEXT STEP";
                    nextStep = true;
                    hand.GetComponent<Animation>().Stop("NewHandAnim");
                    hand.SetActive(false);
                    startTimer = false;
                   timerTik.Stop();
                }
                else
                {
                hand.SetActive(false);
                hand.GetComponent<Animation>().Stop("NewHandAnim");
                text.text = "00:"+seconds.ToString();
                playHandAnim = true;
                }
         
        }
        else
        {
            if (timerTik.isPlaying == true)
            {
                timerTik.Stop(); 
            }
        }


        if (nextStep)
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
        HeartMassage.totalTimeHeartMassage = 18;
        nextStep = false;
        yield return new WaitForSeconds(.1f);
        playCprHeartMassage.Play();
        yield return new WaitForSeconds(10f);
        twoHands.SetActive(true);
        twoHands.GetComponent<Animation>().Play("cprHintAnim");
        heartCube.SetActive(true);
        centerHeartCube.SetActive(true);
        //counterTextCanvas.SetActive(true);
        //counterTextCanvas2.SetActive(true);
        onNeckExit.SetActive(false);
        test.SetActive(false);
        //startTimer = true;
    }


}
