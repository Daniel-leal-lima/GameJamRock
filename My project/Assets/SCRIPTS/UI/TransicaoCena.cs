using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicaoCena : MonoBehaviour
{

    public Animator transicaoAnim;
    string sceneName;
    bool evento;
    // Update is called once per frame
    
    void Update()
    {
        if (evento) // se algum evento aconteceu pra esc
        {
            StartCoroutine(LoadScene(sceneName));
        }
    }

    IEnumerator LoadScene(string sceneName)
    {
        transicaoAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
    public void SetScene(string sceneName)
    {
        this.sceneName = sceneName;
    }
    public void AconteceuEvento()
    {
        evento = true;
    }
}
