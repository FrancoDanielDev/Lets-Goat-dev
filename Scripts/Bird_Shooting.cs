using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Shooting : MonoBehaviour
{
    public GameObject fireball;
    public GameObject position;
    public bool onVision = false;

    public float time;
    public float cd;

    private void FixedUpdate()
    {
        if (GameManager.Instance.onVision == true)
        {
            OnAttack();
        }     
    }

    public void OnAttack()
    {
        time += Time.deltaTime;

        if (time >= cd)
        {
            time = 0;

            GameObject bullet = Instantiate(fireball, position.transform.position, position.transform.rotation);
            
            Destroy(bullet, 1.5f);
        }

        
    }
}
