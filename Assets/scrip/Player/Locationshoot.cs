using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locationshoot : MonoBehaviour
{
    private Camera isMain;
    private Vector3 positonMouse;

    public void Start()
    {
        isMain = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    public void Update()
    {
        positonMouse = isMain.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = positonMouse - transform.position;

        float isZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, isZ);
    }
}
