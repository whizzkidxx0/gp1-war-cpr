using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsLoop : MonoBehaviour
{

     public Light cLight;

    // Start is called before the first frame update
     void Start()
    {
        //Lets start our coroutine, which is just a function
        //that can wait for a given time. Lets make that time
        //a random float between 0 and 2.
        //  StartCoroutine(FlashLights());

        StartCoroutine(FlashLights());
        
    }



    IEnumerator FlashLights()
    {
        //For each light, lets turn it off, wait a certain amount
        //of time, and then turn it on again.
        while (true)
        {
            cLight.enabled = true;
            yield return new WaitForSeconds(1.0f);
            cLight.enabled = false;
            yield return new WaitForSeconds(1.0f);
        }

        
        //  StartCoroutine(FlashLights());
    }

}