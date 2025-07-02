using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class SpawnManager : MonoBehaviour

{
    public void EnableSpawn()
    {
        ObjectSpawner.Instance.enableSpawn = false;
    }
}
