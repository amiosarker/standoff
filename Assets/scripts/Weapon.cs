using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float currenttime = 0f;
    public float starttime = 1f;
    public Transform firepoint1;
    public Transform firepoint2;
    public Transform firepoint3;
    
    public GameObject bulletPrefab;
    void Start()
   {
    currenttime = starttime;
    }
    // Update is called once per frame
    void Update()
    {
        time();
        if(currenttime <= 0)
        {
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
        Instantiate(bulletPrefab, firepoint1.position, firepoint1.rotation);
    }
}
