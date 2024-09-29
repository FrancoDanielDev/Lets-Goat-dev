using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject bullet;
    public GameObject shooting_pos;
    public Animator animator;
    public float cd;
    public float speed;
    public bool activate;

    private void Update()
    {
        if (activate)
        {
            if (gameObject.CompareTag("Left"))
            {
                GameObject ult_bullet = Instantiate(bullet, shooting_pos.transform.position, shooting_pos.transform.rotation);
                ult_bullet.GetComponent<Rigidbody2D>().velocity = Vector3.right * speed;
            }
            else
            {
                GameObject ult_bullet = Instantiate(bullet, shooting_pos.transform.position, shooting_pos.transform.rotation);
                ult_bullet.GetComponent<Rigidbody2D>().velocity = -Vector3.up * speed;
            }

            if (GameManager.Instance.sound)
            {
                AudioManager2.Instance.cannon.Play();
            }
        }
    }
}
