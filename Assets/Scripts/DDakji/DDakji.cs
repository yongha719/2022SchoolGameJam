using DG.Tweening;
using Newtonsoft.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDakji : MonoBehaviour
{
    DDakjichigiManager DDakjichigiManager;
    public Rigidbody Rigid;
    public Transform RotateTr;

    public float RotateValue;

    public static bool IsClicked;

    private void Awake()
    {

    }

    void Start()
    {
        DDakjichigiManager = DDakjichigiManager.Instance;
    }



    private void OnMouseDown()
    {
        if (DDakjichigiManager.IsGameStart)
        {
            Rigid.AddForce(new Vector3(Random.Range(-0.2f, 0.2f), 1.6f, Random.Range(-0.2f, 0.2f)) * 5.0f, ForceMode.Impulse);

            Rigid.angularVelocity = new Vector3(Random.Range(40, 100), 62f, 92f) * 10;

            IsClicked = true;
        }
        else
        {
            DDakjichigiManager.ReSetting();
        }
    }
}
