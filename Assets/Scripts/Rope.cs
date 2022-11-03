using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    private Rigidbody2D rb;

    public float movementSpeed;

    public GameObject go;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("a") || Input.GetKeyDown("s"))
        {
            transform.Translate(Vector3.left);
        }

        if (Input.GetKeyDown("k") || Input.GetKeyDown("l"))
        {
            transform.Translate(Vector3.right);
        }
    }

    private void FixedUpdate()
    {
        
    }
}
