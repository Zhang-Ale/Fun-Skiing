using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoTextAppear : MonoBehaviour
{
    private TextMeshProUGUI goText;
    void Start()
    {
        goText = GameObject.Find("Canvas/Go").GetComponent<TextMeshProUGUI>();
        StartCoroutine(Go());
    }

    IEnumerator Go()
    {
        yield return new WaitForSeconds(2.4f);
        goText.enabled =true;
    }
}
