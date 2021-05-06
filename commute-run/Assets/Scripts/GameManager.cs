using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int TotalGoldCount;
    public int stage;
    public Text PlayerGoldCntText;
    public Text StageGoldCntText;

    private void Awake()
    {
        TotalGoldCount = GameObject.FindGameObjectsWithTag("Gold").Length;
        StageGoldCntText.text = "/ " +( GameObject.FindGameObjectsWithTag("Gold").Length).ToString();

        //if(TotalGoldCount == 0)
        //{
        //    TotalGoldCount = GameObject.FindGameObjectsWithTag("Coin").Length;
        //    StageGoldCntText.text = "/ " + (GameObject.FindGameObjectsWithTag("Coin").Length).ToString();
        //}
    }

    public void GetGold(int count)
    {
        PlayerGoldCntText.text = count.ToString(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(stage);
        }
    }
}
