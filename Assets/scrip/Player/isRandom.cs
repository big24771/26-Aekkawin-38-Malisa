using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class isRandom : MonoBehaviour
{
    //ทำ list point ในการแรนดอมการ spawn
    [SerializeField] private List<Transform> spawnPoint;
    //เอาใส่ออปเจ็คน่อ
    [SerializeField] private GameObject[] box;

    

    // รับค่าspawn และเก็บค่า sapawn ไปใช้นับต่อ **** สำหรับคำตอบ
    [SerializeField] private float spawnCount;
    [SerializeField] public float SpawnCount { get { return spawnCount; } set { spawnCount = value; } }

    // กล่องจะออกมาไม่เกินค่า spawn max ในแต่ละด่าน
    [SerializeField] public float spawnMax;
    [SerializeField] public float SpawnMax { get { return spawnMax; } set { spawnMax = value; } }




    //ทำแรนดอมกล่อง
    private Transform RandomSpawn()

    {
        int randomSpawn = Random.Range(0, spawnPoint.Count);

        return spawnPoint[randomSpawn];

    }

    private GameObject RandomBox() //random กล่องก่อนเอาเข้าไปสุ่ม
    {
        int randomIndex = Random.Range(0, box.Length);
        return box[randomIndex];
    }

    //การสุ่มกล่องลง
    public virtual void ComingBox()
    {
        Transform spawnpoint = RandomSpawn();
        GameObject selectedBox = RandomBox();
        Instantiate(selectedBox, spawnpoint.position, Quaternion.identity);



    }
}
