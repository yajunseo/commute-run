using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeScript : MonoBehaviour
{
    public Transform target;

    float life_t = 5;
    float delta_t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta_t += Time.deltaTime;
        if (life_t < delta_t) Destroy(gameObject);
        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, target.position, 0.05f);
    }
}
