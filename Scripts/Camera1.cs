using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera1 : MonoBehaviour
{
    public Transform player;
    private Transform currentTarget;

    private void Start()
    {
        currentTarget = player;
    }

    private void Update()
    {
        if (currentTarget)
        {
            Vector3 targetPos = new Vector3(currentTarget.position.x, currentTarget.position.y, -10);
            transform.position = targetPos;
        }
    }
}
