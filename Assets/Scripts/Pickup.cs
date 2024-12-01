using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    ScoreKeeper theScoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
        theScoreKeeper = FindFirstObjectByType<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        theScoreKeeper.IncreaseScore();
        Destroy(gameObject);
    }

}