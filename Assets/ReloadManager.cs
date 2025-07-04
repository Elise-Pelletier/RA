using UnityEngine;

public class ReloadManager : MonoBehaviour
{
   public void ReloadScene()
   {
       if (GameManager.instance.gameEnded == true)
            // Reload the current scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
