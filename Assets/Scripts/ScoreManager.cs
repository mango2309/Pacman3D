using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;         // Asigna esto en el Inspector
    public static float scoreCount;

    void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }
}
