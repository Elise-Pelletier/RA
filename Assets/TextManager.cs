using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
public class TextManager : MonoBehaviour
{
    public TMP_Text scoreText; 
    public TMP_Text timerText;

    public void DisplayScore()
    {
        if (CiblesManager.instance == null)
            return;

        scoreText.text = $"Score: {CiblesManager.instance.score}";
    }
    public void DisplayTimer()
    {
        timerText.text = $"Time: {GameManager.instance.timer:F0}";
    }

    void Update()
    {
        DisplayScore();
        DisplayTimer();
    }
}
