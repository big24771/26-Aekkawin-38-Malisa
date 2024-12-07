using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iamnewplayer : IamCharacter
{

    public Iamnewplayer Target;
   

   
    
   
    public void Update()
    {
        Debug.Log($"{Health}");
        if (Health <= 0)
        {

            ChangeScene("lose");


        }
    }

    //·Ó¿Ñ§ªÑ¹ÊÓËÃÑºÂéÒÂ scene
    private void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
