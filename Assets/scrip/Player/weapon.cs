using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class weapon : MonoBehaviour
{
    [SerializeField] public string Ishootable;

    [SerializeField] private int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;

        }
    }

    protected Isshoot shooter;
    public abstract void OnHitWith(Gator _character);
    public abstract void Move();

    public void Init(int _damage, Isshoot _owner)
    {
        Damage = _damage;
        shooter = _owner;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Gator>());
    }

    public int Direction()
    {
        float shootDir = shooter.SpawnPoint.position.x - shooter.SpawnPoint.parent.position.x;
        if (shootDir > 0)
            return 1;
        else return -1;

    }

}
