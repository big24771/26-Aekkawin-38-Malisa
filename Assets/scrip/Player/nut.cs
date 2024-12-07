using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class nut : weapon
{
    private float speed;
    

    public override void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
        Destroy(this, 5);


    }
    public override void OnHitWith(Gator _character)
    {
        if (_character is Gator)
        {

            _character.TakeDamage(this.Damage);
            Destroy(this.gameObject);

        }
    }
   


    private void Start()
    {
        Damage = 50;
        speed = 10.0f * Direction();
        Move();
        

    }

    private void FixedUpdate()
    {
        Move();
        

    }
}
