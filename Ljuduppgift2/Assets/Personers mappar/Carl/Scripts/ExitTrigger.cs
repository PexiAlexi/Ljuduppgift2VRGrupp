using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private GameObject spookyStressSound;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(spookyStressSound);
        SceneManager.LoadScene(sceneName);
    }
}
