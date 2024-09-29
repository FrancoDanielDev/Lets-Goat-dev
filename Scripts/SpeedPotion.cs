using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPotion : MonoBehaviour
{
    public float time;
    bool drunk;
    public CapsuleCollider2D col;
    public SpriteRenderer spr;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager2.Instance.health_up.Play();
            drunk = true;
            spr.enabled = false;
            col.enabled = false;
        }
    }

    private void Update()
    {
        if (drunk)
        {
            GameManager.Instance.speed = 5.4f;
            time += Time.deltaTime;
            GameObject.Find("Protagonist").GetComponent<Renderer>().material.color = Color.cyan;
        }

        if (time > 10)
        {
            time = 0;
            GameManager.Instance.speed = 4;
            drunk = false;
            GameObject.Find("Protagonist").GetComponent<Renderer>().material.color = Color.white;
            Destroy(gameObject);
        }
    }
}
