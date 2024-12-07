using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class isRandom : MonoBehaviour
{
    //�� list point 㹡���ù������ spawn
    [SerializeField] private List<Transform> spawnPoint;
    //�������ͻ�礹��
    [SerializeField] private GameObject[] box;

    

    // �Ѻ���spawn ����纤�� sapawn ���Ѻ��� **** ����Ѻ�ӵͺ
    [SerializeField] private float spawnCount;
    [SerializeField] public float SpawnCount { get { return spawnCount; } set { spawnCount = value; } }

    // ���ͧ���͡������Թ��� spawn max ����д�ҹ
    [SerializeField] public float spawnMax;
    [SerializeField] public float SpawnMax { get { return spawnMax; } set { spawnMax = value; } }




    //���ù������ͧ
    private Transform RandomSpawn()

    {
        int randomSpawn = Random.Range(0, spawnPoint.Count);

        return spawnPoint[randomSpawn];

    }

    private GameObject RandomBox() //random ���ͧ��͹�����������
    {
        int randomIndex = Random.Range(0, box.Length);
        return box[randomIndex];
    }

    //����������ͧŧ
    public virtual void ComingBox()
    {
        Transform spawnpoint = RandomSpawn();
        GameObject selectedBox = RandomBox();
        Instantiate(selectedBox, spawnpoint.position, Quaternion.identity);



    }
}
