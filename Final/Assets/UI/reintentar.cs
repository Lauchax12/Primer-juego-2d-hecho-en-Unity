using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reintentar : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene(3);
    }

    public void retry2()
    {
        SceneManager.LoadScene(6);
    }

}
