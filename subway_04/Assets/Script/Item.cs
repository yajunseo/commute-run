using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float rotateSpeed;
    public GameManager manager;
    public int itemCount;
    Rigidbody rigid;

    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World); //ȸ��
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Player player = other.GetComponent<Player>();
            player.itemCount++;
            gameObject.SetActive(false);

            manager.GetItem(itemCount);
        }
    }
}