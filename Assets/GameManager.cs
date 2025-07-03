using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class GameManager : MonoBehaviour
{
    public float timer = 20f; 
    public static GameManager instance;

    private void Start()
    {
        instance = this;
        // Initialize the timer or any other game state here
    }

    void Update()
    {
        if (ObjectSpawner.Instance.enableSpawn)
            return;

        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            timer = 0;

        }
    }
}
