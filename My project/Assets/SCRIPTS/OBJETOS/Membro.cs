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
    public string nome;
    public Animator luz;

    bool podeBater;
    bool interagiu;
    public string botao;
    public HashSet<GameObject> objtsNoRaio = new HashSet<GameObject>();
    public GameObject nuvemDano;
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
        luz.SetTrigger("acertou");
        SetInteragiu(true); //var pra animação?
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
            GetComponent<Animator>().SetTrigger("hurt");
            // anima��o de dano

        }
    }

    void deletaObjetosAoRedor()
    {
        foreach (GameObject item in objtsNoRaio)
        {
            Destroy(item);
            GameObject efeito = Instantiate(nuvemDano, item.transform.position, Quaternion.identity);
            Destroy(efeito, .5f);
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
