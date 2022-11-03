using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DDakjichigiManager : MonoBehaviour
{
    public static DDakjichigiManager Instance { get; private set; }

    public MeshRenderer DDakjiMesh;

    public Material Green;
    public Material Red;

    public bool IsGameStart;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        StartCoroutine(DDakjichigi());
    }

    // µüÁöÄ¡±â
    IEnumerator DDakjichigi()
    {
        var randomChangeTime = Random.Range(1.5f, 5f);

        yield return new WaitForSeconds(randomChangeTime);

        DDakjiMesh.material = Red;


    }


}

