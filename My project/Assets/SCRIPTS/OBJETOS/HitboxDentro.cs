using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxDentro : MonoBehaviour
{
    public Membro membro;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Não pode mais");
        membro.SetPodeBater(false);
        membro.TomaDano();
        membro.objtsNoRaio.Remove(collision.gameObject);
        Destroy(collision.gameObject);
    }
}
