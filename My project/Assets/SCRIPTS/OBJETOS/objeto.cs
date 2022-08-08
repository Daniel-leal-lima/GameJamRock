using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        StartCoroutine(whatever());
    }

    IEnumerator whatever()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f * Time.deltaTime);
            Destroy(gameObject);
        }
    }
}
