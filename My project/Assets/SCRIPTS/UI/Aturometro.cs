using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aturometro : MonoBehaviour
{
    public float timer, final;
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
        timer += Time.deltaTime;

        if (timer > final)
        {
            MomentoFunc(momento[momentoAtual]);
        }
        else // acaba jogo
        {
            SceneManager.LoadScene("Obrigado");
        }
    }

    void MomentoFunc (Momento momento)
    {
        while(momento.contadorSpawner > -1)
        {
            momento.spawner[momento.contadorSpawner].GetComponent<Spawn>().max = momento.max[momento.contadorSpawner];
            momento.contadorSpawner = momento.contadorSpawner -1;
        }

        if (momento.tempoMax < timer)
        {
            momentoAtual = momentoAtual + 1;
        }
    }
}
