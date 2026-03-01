using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text infoText;
    public Text endText;

    public static int scoreCount;

    private bool infoHidden = false;
    private bool endShown = false;

    void Start()
    {
        if (endText != null)
            endText.gameObject.SetActive(false);
    }

    void Update()
    {
        scoreText.text = "Pieces Found: " + scoreCount;

        if (!infoHidden && scoreCount >= 1)
        {
            infoText.gameObject.SetActive(false);
            infoHidden = true;
        }

        if (!endShown && scoreCount >= 10)
        {
            Debug.Log("Reached 10!");
            endText.gameObject.SetActive(true);
            endShown = true;
        }
    }

    public void AddScore(int amount)
    {
        scoreCount += amount;
    }
}