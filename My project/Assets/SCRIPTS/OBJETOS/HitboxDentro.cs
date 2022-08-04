using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxDentro : MonoBehaviour
{
    public GameObject membro;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ObjetoDano");
        {
            print("AAAAAAA");
            Debug.Log("N�o pode mais");
            membro.GetComponent<Membro>().SetPodeBater(false);
            membro.GetComponent<Membro>().TomaDano();
            membro.GetComponent<Membro>().objtsNoRaio.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
