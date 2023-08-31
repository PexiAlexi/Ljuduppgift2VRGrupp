using System.Collections;
using UnityEngine;

public class MonsterTrigger : MonoBehaviour
{
    public GameObject monster; // Dra och släpp ditt monsterobjekt hit i Unity-editorn
    public float delayBeforeDisappear = 3f; // Antal sekunder innan monstret försvinner

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Kolla om det som träffar zonen är spelaren
        {
            monster.SetActive(true); // Visa monstret
            StartCoroutine(DisappearAfterDelay()); // Starta koroutinen för att låta monstret försvinna
        }
    }

    private IEnumerator DisappearAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeDisappear); // Vänta i x sekunder

        monster.SetActive(false); // Dölj monstret efter väntetiden
    }
}
