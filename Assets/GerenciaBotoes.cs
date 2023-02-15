using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaBotoes : MonoBehaviour
{
   public void Jogar() { }
    public void Creditos() {
        SceneManager.LoadScene(1);
    }
    public void Voltar()
    {
        SceneManager.LoadScene(0);
    }
}
