using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gator : ISennamy
{


    public Iamnewplayer Target;
    public float speed = 2f; // ความเร็วในการเคลื่อนที่





    private void Update()
    {
        // คำนวณทิศทางจากมอนสเตอร์ไปยังผู้เล่น
        Vector2 direction = (Target.transform.position - transform.position).normalized;

        // เคลื่อนที่ไปในทิศทางที่ผู้เล่นอยู่
        transform.position += (Vector3)direction * speed * Time.deltaTime;

        if (IsDead())
        {
           Destroy(this.gameObject);

        }

    }
    public override void OnHitWith(Iamnewplayer character)
    {
        character.TakeDamage(this.Health);
        Destroy(this.gameObject);
    }

}
