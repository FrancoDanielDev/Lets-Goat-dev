using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonist : MonoBehaviour
{
    public Rigidbody2D RB;
    public Animator animator;
    public static Protagonist Instance;
    public SpriteRenderer spr;

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        RB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * GameManager.Instance.speed;
    }

    private void Update()
    {
        animator.SetBool("OnBack", Input.GetKey(KeyCode.W));
        animator.SetBool("OnLeft", Input.GetKey(KeyCode.A));
        animator.SetBool("OnFrontal", Input.GetKey(KeyCode.S));
        animator.SetBool("OnRight", Input.GetKey(KeyCode.D));     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies") && GameManager.Instance.health > 0)
        {
            GameManager.Instance.health--;
            AudioManager2.Instance.prot_hurt.Play();
        }

        if (collision.gameObject.CompareTag("Victory"))
        {
            GameManager.Instance.onVictory = true;
        }

        if (collision.gameObject.CompareTag("Listener"))
        {
            GameManager.Instance.sound = true;
        }

        if (collision.gameObject.CompareTag("unListener"))
        {
            GameManager.Instance.sound = false;
        }
    }     
}
