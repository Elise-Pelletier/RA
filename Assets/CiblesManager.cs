using UnityEngine;
using UnityEngine.InputSystem;

public class CiblesManager : MonoBehaviour
{
    private bool isFallen = false;

    void Update()
    {
        if (!isFallen && transform.position.y < 0.5f)
        {
            isFallen = true;
            Debug.Log("La cible est tombée !");
            // Tu peux ici appeler une méthode pour marquer un point, jouer un son, etc.
        }
    }

}
