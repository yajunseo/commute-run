using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public  float jumpPower = 30;
    public int GoldCount;
    public float speed = 30;
    bool isJump;
    public GameManager manager;
    Rigidbody rigid;
    AudioSource audio;
    Animator anim;

    private void Awake()
    {
        isJump = true;
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v) * speed, ForceMode.Impulse);
         Vector2 vec2 = new Vector2(rigid.velocity.x, rigid.velocity.z);
        anim.SetFloat("Speed", vec2.magnitude);

        //anim.SetFloat("Speed", rigid.velocity.magnitude);
        anim.SetBool("IsJump", isJump);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            isJump = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gold")
        {
            GoldCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetGold(GoldCount);
        }

        else if(other.tag == "Finish")
        {
            if(manager.TotalGoldCount == GoldCount)
            {
                SceneManager.LoadScene(manager.stage + 1);
            }
            else
            {
                SceneManager.LoadScene(manager.stage);
            }
        }
    }
}
