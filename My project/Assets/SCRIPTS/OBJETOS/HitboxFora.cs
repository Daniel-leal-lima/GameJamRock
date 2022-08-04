using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxFora : MonoBehaviour
{
    public GameObject membro;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ObjetoDano")
        {
            print("FORAAAAAAAAAAAA");
            membro.GetComponent<Membro>().SetPodeBater(true);
            membro.GetComponent<Membro>().objtsNoRaio.Add(collision.gameObject);
        }
        
    }
}
