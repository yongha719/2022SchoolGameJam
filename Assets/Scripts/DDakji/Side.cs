using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (DDakji.IsClicked && collision.gameObject.name.Equals("Plane"))
        {
            DDakjichigiManager.Instance.SideCheck(name);
        }
    }
}
