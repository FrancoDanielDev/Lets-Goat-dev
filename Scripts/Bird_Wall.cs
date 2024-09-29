using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Wall : MonoBehaviour
{
    public GameObject bird1;
    public GameObject bird2;
    public GameObject bird3;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(bird1);
            Destroy(bird2);
            Destroy(bird3);
            GameManager.Instance.onVision = false;
        }
    }
}
