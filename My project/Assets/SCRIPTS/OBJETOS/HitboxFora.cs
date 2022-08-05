using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxFora : MonoBehaviour
{
    public GameObject membro;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ObjFlautista" && membro.GetComponent<Membro>().botao == "Fire1" && membro.GetComponent<Membro>().nome == "Flautista")
        {
            membro.GetComponent<Membro>().SetPodeBater(true);
            membro.GetComponent<Membro>().objtsNoRaio.Add(collision.gameObject);
        }
        if(collision.tag == "ObjSolo" && membro.GetComponent<Membro>().botao == "Fire2" && membro.GetComponent<Membro>().nome == "Solo")
        {
            membro.GetComponent<Membro>().SetPodeBater(true);
            membro.GetComponent<Membro>().objtsNoRaio.Add(collision.gameObject);
        }
        if(collision.tag == "ObjGuitarrista" && membro.GetComponent<Membro>().botao == "Fire4" && membro.GetComponent<Membro>().nome == "Guitarrista")
        {
            membro.GetComponent<Membro>().SetPodeBater(true);
            membro.GetComponent<Membro>().objtsNoRaio.Add(collision.gameObject);
        }
        if(collision.tag == "ObjBaterista" && membro.GetComponent<Membro>().botao == "Fire3" && membro.GetComponent<Membro>().nome == "Baterista")
        {
            membro.GetComponent<Membro>().SetPodeBater(true);
            membro.GetComponent<Membro>().objtsNoRaio.Add(collision.gameObject);
        }

    }
}
