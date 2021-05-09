using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScripts : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "KatonMonedas: " + score;
    }

    // public void UpdateScore(int scoreToAdd){
    //     score += scoreToAdd;
    //     scoreText.text = "Katon Monedas: " + score;
    // }
}
