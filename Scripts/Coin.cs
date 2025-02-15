﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MoneyCounter.Instance.counter++;
            AudioManager2.Instance.coin.Play();
            Destroy(gameObject);
        }
    }
}
