using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Potion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.Instance.health < 3 && collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.health++;
            AudioManager2.Instance.health_up.Play();
            Destroy(gameObject);
        }      
    }
}
