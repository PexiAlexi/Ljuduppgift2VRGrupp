using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterScript : MonoBehaviour
{
    public GameObject hedge1;

    private void OnTriggerEnter(Collider other)
    {
        hedge1.gameObject.SetActive(true);

    }

}
