using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsceno : MonoBehaviour
{
    public GameObject slider, siMesmo, plateia;
    public Sprite normal, puto;
    public Animator plateiaAnim;

    void Update()
    {
        if (slider.GetComponent<AturometroSlider>().vida < 5)
        {
            siMesmo.GetComponent<SpriteRenderer>().sprite = puto;
            plateiaAnim.Play("Puto");
        }
        else
        {
            siMesmo.GetComponent<SpriteRenderer>().sprite = normal;
        }
    }
}
