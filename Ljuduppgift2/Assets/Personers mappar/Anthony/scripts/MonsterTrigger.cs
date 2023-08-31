using System.Collections;
using UnityEngine;

public class MonsterTrigger : MonoBehaviour
{
    public GameObject monster; // Dra och sl�pp ditt monsterobjekt hit i Unity-editorn
    public float delayBeforeDisappear = 3f; // Antal sekunder innan monstret f�rsvinner

    private bool hasTriggered = false; // Flagga f�r att h�lla koll p� om triggern har aktiverats

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player")) // Kolla om triggern inte har aktiverats och om det som tr�ffar zonen �r spelaren
        {
            hasTriggered = true; // Markera att triggern har aktiverats
            monster.SetActive(true); // Visa monstret
            StartCoroutine(DisappearAfterDelay()); // Starta koroutinen f�r att l�ta monstret f�rsvinna
        }
    }

    private IEnumerator DisappearAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeDisappear); // V�nta i x sekunder

        monster.SetActive(false); // D�lj monstret efter v�ntetiden
    }
}

