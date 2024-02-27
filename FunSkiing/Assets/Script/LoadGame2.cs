using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame2 : MonoBehaviour
{
    public float time = 19f;
    
    private void Start()
    {
        StartCoroutine(Timer());
    }


    IEnumerator Timer()
    {
        while(true)
        {
            yield return new WaitForSeconds(time);
            LoadGame();
        }
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("LVL.1");

    }
}
