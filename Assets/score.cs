using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    Rigidbody2D rb;
    float moveX, moveY;
    [SerializeField] float speed = 7f;
    private object ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "Coin+10":
                scoretext.scoreValue += 10;
                break;
            case "Coin+50":
                scoretext.scoreValue += 50;
                break;
            case "Coin+30":
                scoretext.scoreValue += 30;
                break;


        }

             
    }
}
