using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Testknap : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("Play game menu");

    }
}



