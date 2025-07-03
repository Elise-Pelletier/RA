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
            Debug.Log("La cible est tomb�e !");
            // Tu peux ici appeler une m�thode pour marquer un point, jouer un son, etc.
        }
    }

}
