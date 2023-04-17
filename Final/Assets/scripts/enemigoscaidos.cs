using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemigoscaidos : MonoBehaviour
{
    public int enemycount = 19;
    
    public void enemydown()
    {
        enemycount = enemycount - 1;
        print("uno menos");
        print(enemycount);
        if (enemycount <= 0)
        {
            SceneManager.LoadScene(8);
        }
    }

}
