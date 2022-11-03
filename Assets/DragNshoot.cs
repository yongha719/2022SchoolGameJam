using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragNshoot : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rb;

    public Vector2 minPower;
    public Vector2 maxPower;

    BestLine tl;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        tl = GetComponent<BestLine>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = cam.ScreenToViewportPoint(Input.mousePosition);
            startPoint.z = 15;
            Debug.Log(startPoint);

        }

            if (Input.GetMouseButton(0))
            {
                Vector3 currenPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                currenPoint.z = 15;
                tl.RenderLine(startPoint, currenPoint);
            }



            if (Input.GetMouseButtonUp(0))
            {

                endPoint = cam.ScreenToViewportPoint(Input.mousePosition);
                endPoint.z = 15;

                force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
                rb.AddForce(force * power, ForceMode2D.Impulse);
                tl.EndLine();
            }
        }
    }


        



