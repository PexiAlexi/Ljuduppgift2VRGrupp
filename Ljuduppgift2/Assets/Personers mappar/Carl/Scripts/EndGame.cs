using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] GameObject soundSource;

    private void Start()
    {
        StartCoroutine(EndSceneCoroutine());
    }

    IEnumerator EndSceneCoroutine()
    {
        yield return new WaitForSeconds(2);
        soundSource.SetActive(true);
        yield return new WaitForSeconds(4);
        Application.Quit();
    }
}
