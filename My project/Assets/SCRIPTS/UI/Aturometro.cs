using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aturometro : MonoBehaviour
{
    public float timer;
    public int momentoAtual;

    [System.Serializable]
    public class Momento 
    {
    public float[] max;
    public float tempoMax;
    public GameObject[] spawner;
    public int contadorSpawner;
    }

    public Momento[] momento;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer > 1)
        {
            MomentoFunc(momento[momentoAtual]);
        }
        //else ACABAR JOGO
    }

    void MomentoFunc (Momento momento)
    {
        while(momento.contadorSpawner > -1)
        {
            momento.spawner[momento.contadorSpawner].GetComponent<Spawn>().max = momento.max[momento.contadorSpawner];
            momento.contadorSpawner = momento.contadorSpawner -1;
        }

        if (momento.tempoMax > timer)
        {
            momentoAtual = momentoAtual + 1;
        }
    }
}
