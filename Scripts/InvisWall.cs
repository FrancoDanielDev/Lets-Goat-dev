using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisWall : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }
}
