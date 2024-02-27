using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KidEscapeTrigger1 : MonoBehaviour
{
    private Text txtMy;
    private TextMeshProUGUI _text;

    void Start()
    {
        txtMy = GameObject.Find("Canvas/Text").GetComponent<Text>();
        _text = GameObject.Find("Canvas/Text (TMP)").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            txtMy.text = " ???";
            txtMy.color = Color.red;
            _text.text = " ???";
            _text.color = Color.red;
        }
    }
}
