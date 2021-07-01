using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 3f;
    public float Jumpforce = 1f;
    private Rigidbody2D rb;
    public float lockPos = 0f;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        transform.rotation = Quaternion.Euler (lockPos ,lockPos ,lockPos);
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0 ,0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump")&& Mathf.Abs(rb.velocity.y)< 0.002f)
        {
         rb.AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
        }
    }
}
