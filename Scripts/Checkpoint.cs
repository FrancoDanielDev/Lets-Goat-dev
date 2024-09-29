using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameMaster gm;
    float z;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MoneyCounter.Instance.last_counter = MoneyCounter.Instance.counter;
            gm.lastCheckPointPos = transform.position;
            gm.lastCheckPointPos.y += 1;
            AudioManager2.Instance.check.Play();
            GameMaster.instance.dead_check = true;
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        z += Time.deltaTime * 50;
        transform.rotation = Quaternion.Euler(0, 0, z);
    }
}
