using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour {

	public void loadLevel2x2()
    {
        SceneManager.LoadScene(1);
    }
    public void loadLevel2x3()
    {
        SceneManager.LoadScene(2);
    }
}
