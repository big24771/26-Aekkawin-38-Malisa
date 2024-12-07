using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class ISennamy : IamCharacter
{
    private int damagehit;
    public int DamageHit
    {
        get
        {
            return damagehit;
        }
        set
        {
            damagehit = value;

        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            OnHitWith(other.GetComponent<Iamnewplayer>());
    }
    public abstract void OnHitWith(Iamnewplayer character);
}
