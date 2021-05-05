using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransfrom;
    Vector3 offset;

    void Awake()
    {
        playerTransfrom = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerTransfrom.position;
    }

    void LateUpdate()
    {
        transform.position = playerTransfrom.position + offset;
    }
}
