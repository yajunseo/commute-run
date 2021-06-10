using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beeSpawn : MonoBehaviour
{
    public GameObject bee;

    public Transform targetPos;
    float spawn_t;
    float delta_t;
    // Start is called before the first frame update
    void Start()
    {
        delta_t = 0;
        spawn_t = 5;
    }

    // Update is called once per frame
    void Update()
    {
        delta_t += Time.deltaTime;
        if (delta_t > spawn_t)
        {
            delta_t = 0;
            GameObject p = Instantiate(bee, transform) as GameObject;
            //p.transform.position = transform.position;
            p.GetComponent<beeScript>().target = targetPos;
        }
    }
}
