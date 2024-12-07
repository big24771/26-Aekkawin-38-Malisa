using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REturn : MonoBehaviour
{
    public void OnMouseDown()
    {
        ChangeScene("SampleScene");
    }
    //ทำฟังชันสำหรับย้าย scene
    private void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
