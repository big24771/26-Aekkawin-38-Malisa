using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface  Isshoot 
{
    
    /// <summary>
    /// ����Ѻ��������ع�ͧ������
    /// </summary>
    GameObject Bullet { get; set; }
    Transform SpawnPoint { get; set; }
    
    /// <summary>
    /// ���˹����ҡ���ԧ�ͧ������
    /// </summary>
    float BulletSpawnTime { get; set; }
    float BulletTime { get; set; }
    void Shoot();
}
