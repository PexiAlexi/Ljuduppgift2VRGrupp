using System.Collections;
using UnityEngine;

public class MonsterTrigger : MonoBehaviour
{
    public GameObject monster; // Dra och sl�pp ditt monsterobjekt hit i Unity-editorn
    public float delayBeforeDisappear = 3f; // Antal sekunder innan monstret f�rsvinner

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Kolla om det som tr�ffar zonen �r spelaren
        {
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
