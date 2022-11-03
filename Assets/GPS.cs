using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{


    // Start is called before the first frame update
    //캐릭터에 대한 이동거리 값

    public GameObject Player;
    public GameObject PLayer2;
    public GameObject Line;
    private float Dist;


    // Update is called once per frame
    void Update()
    {
        Dist = Vector2.Distance(Line.transform.position, PLayer2.transform.position);


    }
    
    private void LateUpdate()
    {
        print("Dist:" + Dist);
    }
}
