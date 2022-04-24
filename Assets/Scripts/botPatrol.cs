using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botPatrol : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    Rigidbody2D rb;
    BoxCollider2D bx;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bx = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (IsFacingRight())
        {
            rb.velocity = new Vector3(moveSpeed, 0f,1f);
        }else
        {
            rb.velocity = new Vector3(-moveSpeed, 0f, 1f);
        }
    }
    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D collision) 
    { 
        transform.localScale = new Vector3(-(transform.localScale.x), transform.localScale.y, 1f);
    }
}
