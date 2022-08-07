using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objeto;
    public float max, randomNumber;
    public Transform selfpos;
    public float timer, contador;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(whatever());
    }

    void SpawnObject()
    {
        Instantiate(objeto, selfpos.position, Quaternion.Euler(0, 180, 0));
    }

    IEnumerator whatever()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f * Time.deltaTime);
            randomNumber = Random.Range(1, max);
            if (randomNumber > 2 && randomNumber < 3)
            {
                SpawnObject();
            }
        }
    }
}