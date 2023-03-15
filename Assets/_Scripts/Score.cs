using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public int score;
    [SerializeField]
    public TextMeshProUGUI scoreTxt;
    public int highscore;
    [SerializeField]
    public TextMeshProUGUI highScoreTxt;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SetScoreTxt();
    }

    public void SetScoreTxt()
    {
        scoreTxt.text = "Score: " + score;
        highscore = PlayerPrefs.GetInt("HighScore");
        highScoreTxt.text = highscore.ToString();
        if(score > highscore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
