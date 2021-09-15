using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myShooting : MonoBehaviour
{
    //public GameObject bullet;
    //public float speed = 100f;
    
    public Camera playerCamera;
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

/*
            Debug.Log("skjOtttttttta");

            //GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;//   Quaternion.identity;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(transform.forward * speed);
            Destroy(instBullet, 1f);//kúl eytt eftir 0.5sek
            */

/*
            
            */