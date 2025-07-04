using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class GameManager : MonoBehaviour
{
    public float timer = 20f; 
    public static GameManager instance;
    public GameObject RestartButton;
    public bool gameEnded = false;


    private void Start()
    {
        instance = this;
        RestartButton.SetActive(false);
    }

    void Update()
    {
        if (ObjectSpawner.Instance.enableSpawn)
            return;

        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            timer = 0;
            gameEnded = true;
            print("Game Over");
            RestartButton.SetActive(true);

        }
    }
}
