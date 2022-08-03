using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nav : MonoBehaviour
{
    public GameObject point;
    public NavMeshAgent perseguidor;
    public string nome;

    void Start()
    {
        
        perseguidor = GetComponent<NavMeshAgent>();
        perseguidor.updateRotation = false;
        perseguidor.updateUpAxis = false;
        point = GameObject.Find(nome);
    }

    // Update is called once per frame
    void Update()
    {

            perseguidor.SetDestination(point.transform.position);


    }
}