using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] public string scene;

    public Animator loadScreen;
    public bool loadLevel = false;

    private void OnTriggerEnter(Collider other)

    {
       StartCoroutine(loadSceneWait());
      
    }
    IEnumerator loadSceneWait()
    {
        loadScreen.SetTrigger("Start");
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene(scene);
    }
}
