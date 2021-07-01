using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 3f;
    public float Jumpforce = 1f;
    private Rigidbody2D rb;
    public float lockPos = 0f;
    public float rotateref = 0f;
    public float flip = 0f;
    public Animator anim;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
         anim.SetFloat("speed", Mathf.Abs(rotateref));
        rotateref = Input.GetAxis("Horizontal");
        transform.rotation = Quaternion.Euler (lockPos ,flip ,lockPos);
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0 ,0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump")&& Mathf.Abs(rb.velocity.y)< 0.5f)
        {
         
         anim.SetBool("isjump", true);
         rb.AddForce(new Vector2(0, Jumpforce), ForceMode2D.Impulse);
         
        }
        if (rotateref < 0)
       {
         flip = 180f;
       }
        if(rotateref > 0)
       {
        flip = 0;
       }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
     anim.SetBool("isjump", false);
    }

}
