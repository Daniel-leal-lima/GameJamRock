using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotoesMenu : MonoBehaviour
{
    public TransicaoCena TransicaoCenaScript;
    public string cena;
    // Start is called before the first frame update
    void Start()
    {
        //Botao.onClick.AddListener(Interagiu);
    }

    public void StartGame()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene(cena);
        TransicaoCenaScript.SetScene(cena);
        TransicaoCenaScript.AconteceuEvento();
        AudioManager.instance.Play("Musica1");
    }

    public void Creditos()
    {
        TransicaoCenaScript.SetScene(cena);
        TransicaoCenaScript.AconteceuEvento();
    }

    public void RetornaMenu()
    {
        TransicaoCenaScript.SetScene(cena);
        TransicaoCenaScript.AconteceuEvento();
    }
}
