using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float currenttime = 0f;
    //public R r;
    public float starttime = 1f;
    public Transform firepoint1;
    public Transform firepoint2;
    public Transform firepoint3;

    public double rotateAmount = 90f;
    public Transform player;
    public Transform enemy;

    public GameObject bulletPrefab;
    void Start()
   {
        //r = GameObject.Find("firepoint");
        currenttime = starttime;
    }
    // Update is called once per frame
    void Update()
    {
        time();
        if(currenttime <= 0)
        {
            //r.Aim();
            
            shoot();
            currenttime = starttime;
        }
    }
    void time()
    {
        currenttime -= 1 * Time.deltaTime;
    }
    void shoot()
    {
        Aim();
        Instantiate(bulletPrefab, firepoint1.position, firepoint1.rotation);
    }

    public void Aim()
    {
        double result = ((double)(player.position.x - enemy.position.x)) / (player.position.y - enemy.position.y);
        double radians = Math.Atan(result);
        rotateAmount = radians * (180.0 / Math.PI);
        rotateAmount = 360 - rotateAmount;
        float ra = (float)rotateAmount;
        this.transform.Rotate(0.0f, 0.0f, -ra);
    }
}
