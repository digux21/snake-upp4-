using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadScene(0); 
    }
    public void tryagain()
    {
        SceneManager.LoadScene(0);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
