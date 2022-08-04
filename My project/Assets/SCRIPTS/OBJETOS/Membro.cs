using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Membro : MonoBehaviour
{
    // Start is called before the first frame update

    public enum myIndex { UM, DOIS, TRES, QUATRO }
    public myIndex selIndex = myIndex.QUATRO;
    public GameObject slider;

    bool podeBater;
    bool interagiu;
    string botao;
    public HashSet<GameObject> objtsNoRaio = new HashSet<GameObject>();
    private void Start()
    {
        switch (selIndex)
        {
            case myIndex.UM:
                botao = "Fire1";
                break;
            case myIndex.DOIS:
                botao = "Fire2";
                break;
            case myIndex.TRES:
                botao = "Fire3";
                break;
            case myIndex.QUATRO:
                botao = "Fire4";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Interage();
    }
    private void FixedUpdate()
    {
        //Debug.Log(botao);
    }

    void Interage()
    {
        if (Input.GetButtonDown(botao) && podeBater)
        { //iremos utilizar o input manager neste jogo
        Debug.Log("Interagiu!");
        SetInteragiu(true); //var pra anima��o?
        deletaObjetosAoRedor();
        //anima��o de quebra de objeto ou desvio
        }
        else if (Input.GetButtonDown(botao))
        {
            Debug.Log("ERROU");
        }
        SetInteragiu(false); //Reset Interagiu
    }

    public void TomaDano()
    {
        if (!interagiu)
        {
            slider.GetComponent<AturometroSlider>().vida = slider.GetComponent<AturometroSlider>().vida -1;
            
            // anima��o de dano
        }
    }

    void deletaObjetosAoRedor()
    {
        foreach (GameObject item in objtsNoRaio)
        {
            Destroy(item);
        }
        objtsNoRaio.Clear();
        SetPodeBater(false);
    }

    public void SetPodeBater(bool var)
    {
        podeBater = var;
    }


    public void SetInteragiu(bool var)
    {
        interagiu = var;
    }
    public bool GetPodeBater()
    {
        return podeBater;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

            print("AAAAAAA");
            SetPodeBater(false);
            TomaDano();
            objtsNoRaio.Remove(collision.gameObject);
            Destroy(collision.gameObject);
            
        
        
    }
}
