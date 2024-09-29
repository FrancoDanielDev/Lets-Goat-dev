using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    void Update()
    {
        transform.LookAt(new Vector3(GameManager.Instance.protagonist.transform.position.x, GameManager.Instance.protagonist.transform.position.y, 0));
        transform.Rotate(new Vector3(0, 90, 90));
    }
}
