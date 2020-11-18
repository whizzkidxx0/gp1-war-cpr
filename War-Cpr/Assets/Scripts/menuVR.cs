using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuVR : MonoBehaviour
{

    [SerializeField]
    private Button credits;


    // Start is called before the first frame update
    void Start()
    {


        credits.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
            Console.WriteLine("LALA");
        });

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
