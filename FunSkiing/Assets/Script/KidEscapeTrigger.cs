using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KidEscapeTrigger : MonoBehaviour
{
    private Text txtMy;
    private TextMeshProUGUI _mytext;
    
    void Start()
    {
        txtMy = GameObject.Find("Canvas (3)/Text").GetComponent<Text>(); 
        _mytext = GameObject.Find("Canvas (3)/Text (TMP)").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            txtMy.text = " ???";
            txtMy.color = Color.red;
            _mytext.text = " ???";
            _mytext.color = Color.red;
        }        
    }
}
