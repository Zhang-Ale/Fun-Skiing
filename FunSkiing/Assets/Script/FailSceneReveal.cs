using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FailSceneReveal : MonoBehaviour
{
    public Image black;
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            //Destroy(other.gameObject);
            StartCoroutine(Fading());
        }

    }
    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene("Fail1");
    }

}
