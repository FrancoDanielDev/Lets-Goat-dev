using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Enemy : MonoBehaviour
{
    public float vision_range;
    public float health;
    public GameObject position; 
    public bool onVision = false;
    public static Bird_Enemy Instance;
    public Animator animator;

    private void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, GameManager.Instance.protagonist.transform.position) < vision_range)
        {
            GameManager.Instance.onVision = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
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
        transform.LookAt(new Vector3(GameManager.Instance.protagonist.transform.position.x, GameManager.Instance.protagonist.transform.position.y, 0));
        transform.Rotate(new Vector3(0, 90, 90));

        if (health <= 0)
        {
            AudioManager2.Instance.enemy_dead.Play();
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        Instance = this;
    }
}
