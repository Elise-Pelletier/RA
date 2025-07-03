using System.Collections.Generic;   
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class CiblesManager : MonoBehaviour
{
    public List<GameObject> cibles;
    public List<Vector3> ciblesPositions;
    private Dictionary<GameObject, bool> fallenStates = new Dictionary<GameObject, bool>();
    public int score = 0;
    public int ciblesTombees = 0;
    private CiblesManager instance;

    void Start()
    {
        instance = this;
        // Initialiser chaque cible comme "non tombée"
        foreach (GameObject cible in cibles)
        {
            fallenStates[cible] = false;
            ciblesPositions.Add(cible.transform.position);
        }
    }

    void Update()
    {
        foreach (GameObject cible in cibles)
        {
            // Vérifie que la cible existe (au cas où elle a été détruite)
            if (cible == null) continue;

            if (!fallenStates[cible] && cible.transform.position.y < 0.5f)
            {
                fallenStates[cible] = true;
                Debug.Log($"La cible {cible.name} est tombée !");
                score++;
                ciblesTombees++;

                if (ciblesTombees == cibles.Count)
                {
                    Debug.Log(gameObject);
                    //Destroy(gameObject);
                    Debug.Log("Table détruite !");
                    ciblesTombees = 0;
                    print(ciblesTombees);
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
            fallenStates[cible] = false; // Réinitialiser l'état de la cible
        }
    }

}
