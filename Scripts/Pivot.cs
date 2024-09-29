using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{
    public Transform player;
    private Transform currentTarget;
    public Prot_Attack prot_attack;
    public AudioSource audio;

    float z;
    public float time;

    private void Awake()
    {
        prot_attack.collider2d.enabled = false;
    }

    private void Start()
    {
        currentTarget = player;
    }

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, z);
        time += Time.deltaTime;

        bool attacking = false;

        if (time > 0.7f)
        {
            attacking = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow)
            || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow);

            prot_attack.animator.SetBool("OnAttack", attacking);

            // Attack Rotation

            if (Input.GetKey(KeyCode.UpArrow))
            {
                z = 180;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                z = -90;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                z = 90;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                z = 0;
            }
        }      

        if (currentTarget)
        {
            Vector3 targetPos = new Vector3(currentTarget.position.x, currentTarget.position.y);
            transform.position = targetPos;
        }

        if (attacking)
        {
            time = 0;
            audio.Play();
        }

    }
}
