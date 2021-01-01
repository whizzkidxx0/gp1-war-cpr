using System;
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
    public AudioSource heavyBreathingSound;
    public static int sceneCounter = 0; 
    //public Text counterText;
    public GameObject counterCanvas;
    public GameObject counterCanvas2;
    public Text counterText;
    public Text counterText2;



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

            if (heavyBreathingSound.isPlaying == false)
            {
                heavyBreathingSound.Play();
            }
            if (sceneCounter == 0)
            {
                counterCanvas2.SetActive(true);
            }
            else if(sceneCounter == 1)
            {
                counterCanvas.SetActive(true);
            }
            txt.SetActive(true);
            totalTimeHeartMassage -= Time.deltaTime;
            seconds = (int)(totalTimeHeartMassage % 60);
         
            if (seconds <= 0)
            {
                cube.SetActive(false);
                childCube.SetActive(false);
                canvas.SetActive(false);
                //text.text = "NEXT STEP";
                text.text = "";
                nextStepHeartMassage = true;
                hand.GetComponent<Animation>().Stop("cprHintAnim");
                hand.SetActive(false);
                heavyBreathingSound.Stop();
                startTimerHeartMassage = false;
                if (sceneCounter == 0)
                {
                    counterCanvas2.SetActive(false);
                }
                else if (sceneCounter == 1)
                {
                    counterCanvas.SetActive(false);
                }
            }
            else
            {
                hand.SetActive(false);
                hand.GetComponent<Animation>().Stop("cprHintAnim");
                text.text = seconds.ToString();
                playHandAnimHeartMassage = true;
            }

        }
        else
        {
            if (heavyBreathingSound.isPlaying == true)
            {
                heavyBreathingSound.Stop();
            }
        }



        if (nextStepHeartMassage)
        {
            if (playNext.isPlaying == false)
            {
                if (sceneCounter == 0)
                {
                    StartCoroutine(playNextScene());
                    sceneCounter++;
                }
                if(sceneCounter == 1)
                {
                    StartCoroutine(playFinalSceneGood());
                }
            }
        }

    }


    IEnumerator playNextScene()
    {
        if (sceneCounter == 0)
        {
            //PlayerPrefs.SetInt("FirstScore", ChildCubeInterract.counter2);
            playNext.Play();
            yield return new WaitForSeconds(10);
            playNext.Stop();
            LipsCollision.totalTimeLip = 5;
            nextStepHeartMassage = false;
            yield return new WaitForSeconds(.1f);
            mouthCube.SetActive(true);
            lips.SetActive(true);
            heartCube.SetActive(false);
            centerHeartCube.SetActive(false);
        }
    }


    IEnumerator playFinalSceneGood()
    {
        if (sceneCounter == 1)
        {
            //PlayerPrefs.SetInt("SecondScore", ChildCubeInterract.counter);
            //playNext.Play();
            //yield return new WaitForSeconds(10);
            //playNext.Stop();
            //LipsCollision.totalTimeLip = 5;
            nextStepHeartMassage = false;
            yield return new WaitForSeconds(.1f);
            mouthCube.SetActive(false);
            lips.SetActive(false);
            heartCube.SetActive(false);
            centerHeartCube.SetActive(false);
            canvas.SetActive(true);
            double scores = double.Parse(counterText.text) + double.Parse(PlayerPrefs.GetInt("SecondScore").ToString());
            double totalScore = (scores / 60.0) * 100.0;
            if (totalScore <= 100.0)
            {
                if (LipsCollision.showScore)
                {
                    text.text = "score : " + (Math.Round(totalScore, 2)).ToString() + "%";
                }
            }
            else
            {
                double totalScoreModulo = totalScore % 100.0;
                double finalScore = 100.0 - totalScoreModulo;
                if (LipsCollision.showScore)
                {
                    text.text = "score : " + (Math.Round(finalScore, 2)).ToString() + "%";
                }
            }
        }
    }

    //IEnumerator playFinalSceneBad()
    //{
    //    //PlayerPrefs.SetInt("SecondScore", ChildCubeInterract.counter);
    //    yield return new WaitForSeconds(.1f); 
    //    nextStepHeartMassage = false; 
    //    heartCube.SetActive(false);
    //    centerHeartCube.SetActive(false);
    //    canvas.SetActive(true);
    //    text.text = "test : " + (PlayerPrefs.GetInt("FirtScore") + PlayerPrefs.GetInt("SecondScore")).ToString();
    //}

}
