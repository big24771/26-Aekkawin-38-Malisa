using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Isstart : isRandom
{
    private void Update()
    {

       if(Input.GetKeyDown(KeyCode.R))
        {//loop ����Ѻ��� random spawn
            for (int i = 0; i < spawnMax; i++)
            {
                ComingBox();



            }
           
        }

       

       

    }
}
