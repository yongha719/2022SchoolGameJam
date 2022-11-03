using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Data.Common;
using UnityEngine.PlayerLoop;

public class DDakjichigiManager : MonoBehaviour
{
    public static DDakjichigiManager Instance { get; private set; }

    public MeshRenderer DDakjiMesh;

    public Material Green;
    public Material Red;

    public float DelayTime;

    public bool IsGameStart;

    IEnumerator DDakjichigi;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        DDakjichigi = GetDDakjichigiCoroutine();
        StartCoroutine(DDakjichigi);
        StopCoroutine(DDakjichigi);
    }

    private void Update()
    {

    }

    public void ReSetting()
    {
        print("re");
        StopCoroutine(DDakjichigi);
        StartCoroutine(GetDDakjichigiCoroutine());
    }

    // ����ġ��
    private IEnumerator GetDDakjichigiCoroutine()
    {
        var randomChangeTime = Random.Range(1.5f, 5f);

        yield return new WaitForSeconds(randomChangeTime);
        print(Time.time);
        yield return new WaitForSeconds(randomChangeTime);
        print(Time.time);

        yield return new WaitForSeconds(randomChangeTime);
        print(Time.time);

        yield return new WaitForSeconds(randomChangeTime);

        print("stop");
        DDakjiMesh.material = Red;
        IsGameStart = true;
    }

    // ���� ������� �ٽ� ����
    public void ReStart()
    {
        print(nameof(ReStart));
    }

    /// <summary>
    /// �ո����� �޸����� üũ
    /// </summary>
    public void SideCheck(string side)
    {
        print(side);
        switch (side)
        {
            case "Front":
                break;
            case "Back":
                break;
        }
    }
}

