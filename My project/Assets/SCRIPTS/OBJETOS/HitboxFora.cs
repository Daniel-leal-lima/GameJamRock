using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxFora : MonoBehaviour
{
    public Membro membro;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Pode bater");
        membro.SetPodeBater(true);
    }
}
