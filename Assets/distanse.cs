using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Transform other;
    void Example()
    {
        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);
            print("Distance to other: " + dist);
        }
    }
}
