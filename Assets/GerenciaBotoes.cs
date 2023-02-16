using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaBotoes : MonoBehaviour
{
    public void Creditos() {
        SceneManager.LoadScene(1);
    }
    public void Voltar()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Jogar()
    {
        SceneManager.LoadScene(2);
    }
}
