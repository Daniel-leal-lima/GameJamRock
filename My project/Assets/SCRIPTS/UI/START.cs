using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class START : MonoBehaviour
{
    public Button Botao;
    // Start is called before the first frame update
    void Start()
    {
        Botao.onClick.AddListener(Interagiu);
    }

    void Interagiu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase1");
    }
}