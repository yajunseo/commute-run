using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class globalValue
{
    public static int score;
}

public class GameManager : MonoBehaviour
{
    public int TotalGoldCount;
    public int stage;
    public int RoationObsacle;
    public Text PlayerGoldCntText;
    public Text StageGoldCntText;
    public Text scoreText;

    private void Awake()
    {
        if(TotalGoldCount != null)
            TotalGoldCount = GameObject.FindGameObjectsWithTag("Gold").Length;

        if (StageGoldCntText != null)
            StageGoldCntText.text = "/ " +( GameObject.FindGameObjectsWithTag("Gold").Length).ToString();

        if(stage == 0)
        {
            Debug.Log("스타트 스테이지");
            globalValue.score = 0;
        }

        else if (stage == 4)
        {
            Debug.Log("점수 스테이지");
            scoreText.text = "SCORE : " + globalValue.score;
        }
        //if(TotalGoldCount == 0)
        //{
        //    TotalGoldCount = GameObject.FindGameObjectsWithTag("Coin").Length;
        //    StageGoldCntText.text = "/ " + (GameObject.FindGameObjectsWithTag("Coin").Length).ToString();
        //}
    }

    private void Update()
    {
        if (stage == 0)
        {
            Debug.Log("스타트 스테이지");
            globalValue.score = 0;
        }

        else if (stage == 4)
        {
            Debug.Log("점수 스테이지");
            scoreText.text = "SCORE : " + globalValue.score;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
                    Application.Quit();   // 종료한다
#endif
        }
    }

        public void GetGold(int count)
    {
        PlayerGoldCntText.text = count.ToString(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(stage);
        }
    }
}