using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreKeeper : MonoBehaviour
{
    int score = 0;
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText= GetComponent<Text>();

    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}