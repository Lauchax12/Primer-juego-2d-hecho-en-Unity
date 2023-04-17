using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasaraltutorial2 : MonoBehaviour
{
    public void tutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    } 

    public void tutorial2()
    {
        SceneManager.LoadScene(6);
    }
}
