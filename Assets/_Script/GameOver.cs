using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameovercan;
    // Start is called before the first frame update
    void Start()
    {
        gameovercan.SetActive(false);
        Time.timeScale = 1;
        EnemyCon.gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyCon.gameover)
        {
            gameovercan.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
