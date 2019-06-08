using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score = Mathf.RoundToInt(Time.timeSinceLevelLoad);
        text.text = score.ToString();
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("Score", score);
        int highscore = PlayerPrefs.GetInt("HighScore", 0);
        if(score > highscore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
