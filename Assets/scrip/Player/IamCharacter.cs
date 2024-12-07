using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IamCharacter : MonoBehaviour
{

    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    
    public Animator Animation; //�Ѻ���animation������
    public Rigidbody2D rb;//���rigibody �ͧ������������
   


    //method

    public bool IsDead()
    {
        if (health <= 0)
        { 
            return true;
        }
        return false;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
       
   
}
