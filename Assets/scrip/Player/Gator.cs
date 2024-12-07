using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gator : ISennamy
{


    public Iamnewplayer Target;
    public float speed = 2f; // ��������㹡������͹���





    private void Update()
    {
        // �ӹǳ��ȷҧ�ҡ�͹�������ѧ������
        Vector2 direction = (Target.transform.position - transform.position).normalized;

        // ����͹����㹷�ȷҧ������������
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
