using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHandler : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToDeactivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Kolla om det som träffade triggerzonen är spelaren
        {
            objectToActivate.SetActive(true); // Aktivera objektet
            objectToDeactivate.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objectToActivate.SetActive(false);
            objectToDeactivate.SetActive(true);
        }
    }
   
}
