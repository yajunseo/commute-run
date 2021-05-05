using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCan : MonoBehaviour
{
    public float rotateSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World); //È¸Àü
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Player player = other.GetComponent<Player>();
            player.itemCount++;
            gameObject.SetActive(false);
        }
    }
}