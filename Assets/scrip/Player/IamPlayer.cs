using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IamPlayer : IamCharacter,Isshoot
{
    [field: SerializeField] public GameObject Bullet { get; set; }

    [SerializeField] private Transform spawnPoint;
    public Transform SpawnPoint { get { return spawnPoint; } set { spawnPoint = value; } }

    //colldown bullet
    [SerializeField] private float bulletSpawnTime;
    public float BulletSpawnTime { get { return bulletSpawnTime; } set { bulletSpawnTime = value; } }

    [SerializeField] private float bulletTime;
    public float BulletTime { get { return bulletTime; } set { bulletTime = value; } }
    public void Shoot()
    {

        if (Input.GetButtonDown("Fire1") && BulletTime >= BulletSpawnTime)
        {
            GameObject obj = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);

            nut banana = obj.GetComponent<nut>();

            banana.Init(10, this);
            Destroy(obj,5);

            BulletTime = 0;
        }

    }
    //
    public void Start()
    {
        
        BulletTime = 0;
        BulletSpawnTime = 0.5f;

    }
    public void Update()
    {
        Shoot();
    }
    public void FixedUpdate()
    {
        BulletTime += Time.fixedDeltaTime;

    }

}
