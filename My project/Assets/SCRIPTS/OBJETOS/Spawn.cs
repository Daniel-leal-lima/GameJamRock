using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objeto;
    public float max, randomNumber;
    public Transform selfpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(1, max);

        if (randomNumber > 2 && randomNumber < 3)
        {
            SpawnObject(); 
        }
    }

    void SpawnObject()
    {
        Instantiate(objeto, selfpos.position, Quaternion.Euler(0, 180, 0));
    }
}
