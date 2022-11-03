using Newtonsoft.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDakji : MonoBehaviour
{
    DDakjichigiManager DDakjichigiManager;


    void Start()
    {
        DDakjichigiManager = DDakjichigiManager.Instance;
    }

    void Update()
    {
        
    }

    private async void OnMouseDown()
    {
        if (DDakjichigiManager.IsGameStart)
        {
        }
    }
}
