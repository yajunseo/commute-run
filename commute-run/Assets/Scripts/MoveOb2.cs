using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOb2 : MonoBehaviour
{
    public float startTime;
    public float minX, maxX;
    public float moveSpeed;

    private float sign = -1;


    private void Update()
    {
        if (Time.time >= startTime)
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime * sign, 0, 0);


            if (transform.position.y <= minX ||
                transform.position.y >= maxX)
            {
                sign *= -1;
            }
        }
    }
}
