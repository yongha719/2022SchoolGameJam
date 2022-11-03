using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("DDakji") && DDakji.IsClicked)
        {
            DDakjichigiManager.Instance.ReStart();
        }
    }
}
