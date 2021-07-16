using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qwer : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public int hurt;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        Movement move = hitinfo.GetComponent<Movement>();
        if (move != null)
        {
            move.Damage(hurt);
        }
        //Debug.Log(hitinfo.name);
        Destroy(gameObject);
    }
}
