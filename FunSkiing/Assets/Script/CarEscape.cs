using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarEscape : MonoBehaviour
{
    private GameObject _SkiCoach;
    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        _SkiCoach = GameObject.FindGameObjectWithTag("Coach");

        text = GameObject.Find("Canvas (2)/Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            text.text = "Now we out!!";

            _SkiCoach.SetActive(false);

        }
        
    }
}
