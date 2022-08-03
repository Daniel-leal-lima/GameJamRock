using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AturometroSlider : MonoBehaviour
{
    public Slider slider;
    int max = 10;
    [SerializeField]
    int cont;
    float progresso;
    private void Start()
    {
        cont = max;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cont -= 1;
        }
        progresso = (float) cont / max;
        Debug.Log("progresso: " + progresso);
        slider.value = progresso;
    }
}
