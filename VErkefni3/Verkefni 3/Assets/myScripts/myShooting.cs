using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myShooting : MonoBehaviour
{
    //public GameObject bullet;
    //public float speed = 100f;
    
    public GameObject playerCamera;
    public GameObject bulletPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            bulletObject.transform.forward = playerCamera.transform.forward;

        }
    }
}