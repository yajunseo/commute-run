using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOb : MonoBehaviour
{
   public float startTime;
   public float minY, maxY;
   public float moveSpeed;

    private float sign = -1;


    private void Update()
    {
        if(Time.time >= startTime)
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime * sign, 0);


            if (transform.position.y <= minY ||
                transform.position.y >= maxY)
            {
                sign *= -1;
            }
        }
    }
}
