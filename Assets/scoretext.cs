using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.UI;

public class scoretext : MonoBehaviour
{
    Text text;
    public static int scoreValue;


    void Start()
    {
       
        text = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Score : " + scoreValue;    
    }
}
