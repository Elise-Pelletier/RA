using System.Collections.Generic;   
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;
using TMPro;

public class CiblesManager : MonoBehaviour
{
    public List<GameObject> cibles;
    public List<Vector3> ciblesPositions;
    private Dictionary<GameObject, bool> fallenStates = new Dictionary<GameObject, bool>();
    public int score = 0;
    public int ciblesTombees = 0;
    public static CiblesManager instance;
    public GameObject plateau;



    public void Start()
    {
        instance = this;
        // Initialiser chaque cible comme "non tomb�e"
        foreach (GameObject cible in cibles)
        {
            fallenStates[cible] = false;
            ciblesPositions.Add(cible.transform.position);
        }
    }

    public void Update()
    {
        foreach (GameObject cible in cibles)
        {
            // V�rifie que la cible existe (au cas o� elle a �t� d�truite)
            if (cible == null) continue;

            if (!fallenStates[cible] && cible.transform.position.y < plateau.transform.position.y)
            {
                fallenStates[cible] = true;
                Debug.Log($"La cible {cible.name} est tomb�e !");
                score++;
                ciblesTombees++;


                if (ciblesTombees == cibles.Count)
                {
                    ciblesTombees = 0;
                    RestartCibles();

                }
            }
        }
    }

    public void RestartCibles()
    {
        foreach (GameObject cible in cibles)
        {

            cible.transform.position = ciblesPositions[cibles.IndexOf(cible)];
            cible.transform.rotation = Quaternion.identity;
            Rigidbody rb = cible.GetComponent<Rigidbody>();
            rb.angularVelocity = Vector3.zero;
            rb.linearVelocity = Vector3.zero;
            fallenStates[cible] = false; // R�initialiser l'�tat de la cible
        }
    }

   
}
