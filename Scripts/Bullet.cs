using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float moveSpeed = 7f;

    Rigidbody2D RB;

    Protagonist target;
    Vector2 moveDirection;

    private void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Protagonist>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        RB.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 1.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
