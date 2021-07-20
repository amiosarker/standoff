using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public double rotateAmount = 90f;
    public Transform player;
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        //enemy = Weapon.firepoint1;
        //rotateAmount = 360 - rotateAmount;
        rotateAmount = 270f;
        this.transform.Rotate(0, 0, (float)rotateAmount);
        //this.transform.RotateAround(this.transform.parent.position, this.transform.parent.forward, rotateAmount * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.RotateAround(this.transform.parent.position, this.transform.parent.forward, rotateAmount * Time.deltaTime);
        //rotateAmount = 90;
        //rotateAmount %= 360;
        
    }
    public void Aim()
    {
        double result = ((double)(player.position.x-enemy.position.x))/(player.position.y-enemy.position.y);
        double radians = Math.Atan(result);
        rotateAmount = radians * (180.0/Math.PI);
        float ra = (float)rotateAmount;
		this.transform.Rotate(0.0f, 0.0f, ra);
    }
 }