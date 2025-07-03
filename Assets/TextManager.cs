using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
public class TextManager : MonoBehaviour
{
    public TMP_Text scoreText;  

    public void DisplayScore()
    {
        if (CiblesManager.instance == null)
            return;

        //print(CiblesManager.instance.score);
        scoreText.text = $"Score: {CiblesManager.instance.score}";
    }

    void Update()
    {
        DisplayScore();
    }
}
