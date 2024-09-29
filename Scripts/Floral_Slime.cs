using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floral_Slime : MonoBehaviour
{
    public float speed;
    public float vision_range;
    public float health;
    public Rigidbody2D RB;
    public float knockback;

    bool onVision = false;

    private void FixedUpdate()
    { 
        if (Vector2.Distance(transform.position, GameManager.Instance.protagonist.transform.position) < vision_range)
        {
            onVision = true;
        }

        if (onVision)
        {
            Vector2 direction = GameManager.Instance.protagonist.transform.position - transform.position;
            RB.velocity = direction.normalized * speed;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, vision_range);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Attack"))
        {
            AudioManager2.Instance.enemy_hurt.Play();
            health--;
        }
    }

    private void Update()
    {
        if (health <= 0)
        {
            AudioManager2.Instance.enemy_dead.Play();
            Destroy(gameObject);
        }
    }

}
