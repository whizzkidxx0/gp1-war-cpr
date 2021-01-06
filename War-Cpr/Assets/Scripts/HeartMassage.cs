using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
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
    public GameObject visionEffect;
    public AudioSource heartBeat;
    public AudioSource timerTik;
    public static int sceneCounter = 0; 
    //public Text counterText;
    public GameObject counterCanvas;
    public GameObject counterCanvas2;
    public Text counterText;
    public Text counterText2;

    public AudioSource Respond;
    public AudioSource YouDidYourBest;
    public AudioSource WhatsThatNotAgain;
    public AudioSource GetCover;
    public AudioSource Jet;
    public AudioSource Cry;
    public AudioSource explosionSound;
    public AudioSource dyingSound;
    public AudioSource flashSound;
    public AudioSource heartBeatSound;
    public AudioSource wrSound;

    public GameObject explosionRig;
    public GameObject explosionRig2;
    public GameObject explosionRig3;


    public GameObject jetObj;
    public GameObject explosionParticle1;
    public GameObject explosionParticle2;
    public GameObject explosionParticle3;
    public GameObject explosionParticle4;
    public GameObject explosionParticle5;
    public GameObject explosionParticle6;
    public GameObject explosionParticle7;
    public GameObject explosionParticle8;
    public GameObject explosionParticle9;
    public GameObject explosionParticle10;
    public GameObject explosionParticle11;
    public GameObject explosionParticle12;
    public GameObject explosionParticle13;
    public GameObject explosionParticle14;
    public GameObject explosionParticle15;
    public GameObject explosionParticle16;
    public GameObject explosionParticle17;
    public GameObject explosionParticle18;
    public GameObject explosionParticle19;
    public GameObject explosionParticle20;
    public GameObject explosionParticle21;
    public GameObject explosionParticle22;
    public GameObject explosionParticle23;
    public GameObject explosionParticle24;
    public GameObject explosionParticle25;
    public GameObject explosionParticle26;
    public GameObject explosionParticle27;

    public GameObject air;
    public GameObject finalCvs;
    public GameObject GloVol2;
    public Volume v;
    public Volume v2;
    public AudioSource DieLit;
    public GameObject DirLight;









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
                visionEffect.SetActive(true);
                heartBeat.Play();
                timerTik.Play();
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
                visionEffect.SetActive(false);
                timerTik.Stop();
                heartBeat.Stop();
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
                text.text = "00:"+seconds.ToString();
                playHandAnimHeartMassage = true;
            }

        }
        else
        {
            if (heavyBreathingSound.isPlaying == true)
            {
                heavyBreathingSound.Stop();
                visionEffect.SetActive(false);
                timerTik.Stop();
                heartBeat.Stop();
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
            double totalScoreModulo = totalScore % 100.0;
            double finalScore = 100.0 - totalScoreModulo;

            if (totalScore <= 100.0)
            {
                if (LipsCollision.showScore)
                {
                    PlayerPrefs.SetFloat("FinalScore", (float)(Math.Round(totalScore, 2)));

                    if ((float)(Math.Round(totalScore, 2)) >= 50.0)
                    {

                        SceneManager.LoadScene(9);
                    }
                    else
                    {
                        Respond.Play();
                        yield return new WaitForSeconds(3);
                        YouDidYourBest.Play();
                        Jet.Play();
                        yield return new WaitForSeconds(4);
                        Cry.Play();
                        visionEffect.SetActive(true);
                        yield return new WaitForSeconds(4);
                        WhatsThatNotAgain.Play();
                        heartBeatSound.Play();
                        wrSound.Play();
                        GloVol2.SetActive(true);
                        v.weight = 1f;
                        jetObj.SetActive(true);
                        jetObj.GetComponent<Animation>().Play("FinalBadEndingPlane");
                        yield return new WaitForSeconds(2f);
                        GetCover.Play();
                        yield return new WaitForSeconds(2);
                        DieLit.Play();
                        explosionSound.Play();
                        heartBeatSound.volume = .08f;
                        wrSound.volume = .1f;
                        Cry.Stop();
                        dyingSound.Play();
                        flashSound.Play();
                        explosionParticle1.SetActive(true);
                        explosionParticle2.SetActive(true);
                        explosionParticle3.SetActive(true);
                        explosionParticle4.SetActive(true);
                        explosionParticle5.SetActive(true);
                        explosionParticle6.SetActive(true);
                        explosionParticle7.SetActive(true);
                        explosionParticle8.SetActive(true);
                        explosionParticle10.SetActive(true);
                        explosionParticle11.SetActive(true);
                        explosionParticle12.SetActive(true);
                        explosionParticle13.SetActive(true);
                        explosionParticle14.SetActive(true);
                        explosionParticle15.SetActive(true);
                        explosionParticle16.SetActive(true);
                        explosionParticle17.SetActive(true);
                        explosionParticle18.SetActive(true);
                        explosionParticle19.SetActive(true);
                        explosionParticle20.SetActive(true);
                        explosionParticle21.SetActive(true);
                        explosionParticle22.SetActive(true);
                        explosionParticle23.SetActive(true);
                        explosionParticle24.SetActive(true);
                        explosionParticle25.SetActive(true);
                        explosionParticle26.SetActive(true);
                        explosionParticle27.SetActive(true);
                        explosionRig.SetActive(true);
                        explosionRig2.SetActive(true);
                        explosionRig3.SetActive(true);
                        yield return new WaitForSeconds(3);
                        air.SetActive(true);
                        DirLight.SetActive(false);
                        finalCvs.SetActive(true);
                        explosionRig.SetActive(false);
                        explosionRig2.SetActive(false);
                        explosionRig3.SetActive(false);
                        yield return new WaitForSeconds(5f);
                        SceneManager.LoadScene(9);
                    }

                    //text.text = "score : " + (Math.Round(totalScore, 2)).ToString() + "%";
                }
            }
            else
            {
           
                if (LipsCollision.showScore)
                {
                    PlayerPrefs.SetFloat("FinalScore", (float)(Math.Round(finalScore, 2)));

                    if((float)(Math.Round(finalScore, 2)) >= 50.0)
                    {




                        SceneManager.LoadScene(9);
                    }
                    else
                    {
                        Respond.Play();
                        yield return new WaitForSeconds(3);
                        YouDidYourBest.Play();
                        Jet.Play();
                        yield return new WaitForSeconds(4);
                        Cry.Play();
                        visionEffect.SetActive(true);
                        yield return new WaitForSeconds(4);
                        WhatsThatNotAgain.Play();
                        heartBeatSound.Play();
                        wrSound.Play();
                        GloVol2.SetActive(true);
                        v.weight = 1f;
                        jetObj.SetActive(true);
                        jetObj.GetComponent<Animation>().Play("FinalBadEndingPlane");
                        yield return new WaitForSeconds(2f);
                        GetCover.Play();
                        yield return new WaitForSeconds(2);
                        DieLit.Play();
                        explosionSound.Play();
                        heartBeatSound.volume = .08f;
                        wrSound.volume = .1f;
                        Cry.Stop();
                        dyingSound.Play();
                        flashSound.Play();
                        explosionParticle1.SetActive(true);
                        explosionParticle2.SetActive(true);
                        explosionParticle3.SetActive(true);
                        explosionParticle4.SetActive(true);
                        explosionParticle5.SetActive(true);
                        explosionParticle6.SetActive(true);
                        explosionParticle7.SetActive(true);
                        explosionParticle8.SetActive(true);
                        explosionParticle10.SetActive(true);
                        explosionParticle11.SetActive(true);
                        explosionParticle12.SetActive(true);
                        explosionParticle13.SetActive(true);
                        explosionParticle14.SetActive(true);
                        explosionParticle15.SetActive(true);
                        explosionParticle16.SetActive(true);
                        explosionParticle17.SetActive(true);
                        explosionParticle18.SetActive(true);
                        explosionParticle19.SetActive(true);
                        explosionParticle20.SetActive(true);
                        explosionParticle21.SetActive(true);
                        explosionParticle22.SetActive(true);
                        explosionParticle23.SetActive(true);
                        explosionParticle24.SetActive(true);
                        explosionParticle25.SetActive(true);
                        explosionParticle26.SetActive(true);
                        explosionParticle27.SetActive(true);
                        explosionRig.SetActive(true);
                        explosionRig2.SetActive(true);
                        explosionRig3.SetActive(true);
                        yield return new WaitForSeconds(3);
                        air.SetActive(true);
                        DirLight.SetActive(false);
                        finalCvs.SetActive(true);
                        explosionRig.SetActive(false);
                        explosionRig2.SetActive(false);
                        explosionRig3.SetActive(false);
                        yield return new WaitForSeconds(5f);
                        SceneManager.LoadScene(9);
                    }


                    //text.text = "score : " + (Math.Round(finalScore, 2)).ToString() + "%";
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
