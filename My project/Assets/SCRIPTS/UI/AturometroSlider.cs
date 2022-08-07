using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AturometroSlider : MonoBehaviour
{
    public float vida, porcentagem;
    public Slider slider;
    public int max;
    public GameObject fill;
    [SerializeField]
    float progresso;
    Image col;
    private void Start()
    {
        vida = max;
        
    }
    // Update is called once per frame
    void Update()
    {
        progresso = (float) vida / max;
        //Debug.Log("progresso: " + progresso);
        slider.value = progresso;

        float porcentagem = progresso * 100;

        if (porcentagem > 50)
        {
            fill.GetComponent<Image>().color = Color.green;
            //print("verde");
        }
        else if (porcentagem > 25)
        {
            fill.GetComponent<Image>().color = Color.yellow;
            //print("amarelo");
        }
        else
        {
            fill.GetComponent<Image>().color = Color.red;
            //print("vermelho");
        }

        if (vida <= 0)
        {
            AudioManager.instance.Stop("Musica1");
            SceneManager.LoadScene("GameOver");
        }
    }
}
