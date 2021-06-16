using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Stage1Button()
    {
        SceneManager.LoadScene(1);
    }

    public void Stage2Button()
    {
        SceneManager.LoadScene(2);
    }

    public void Stage3Button()
    {
        SceneManager.LoadScene(3);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }


}
