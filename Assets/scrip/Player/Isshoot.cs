using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface  Isshoot 
{
    
    /// <summary>
    /// สำหรับแค่ใส่กระสุนของผู้เล่น
    /// </summary>
    GameObject Bullet { get; set; }
    Transform SpawnPoint { get; set; }
    
    /// <summary>
    /// ใช้กำหนดเวลาการยิงของผู้เล่น
    /// </summary>
    float BulletSpawnTime { get; set; }
    float BulletTime { get; set; }
    void Shoot();
}
