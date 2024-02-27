using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetPointer : MonoBehaviour
{
    public GameObject arrow;
    CanvasGroup arrowCanvas;
    public Transform objective;
    private Transform playerTransform;
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        arrowCanvas = arrow.GetComponent<CanvasGroup>();
        arrowCanvas.alpha = 0;
        StartCoroutine(ArrowRender());
    }

    void Update()
    {
        if (objective != null)
        {
            Vector3 dir = playerTransform.InverseTransformPoint(objective.position);
            float a = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            a += 100;
            arrow.transform.localEulerAngles = new Vector3(0, 180, a);
        }
    }

    IEnumerator ArrowRender()
    {
        arrowCanvas.alpha = 0;
        yield return new WaitForSeconds(0.1f);
        arrowCanvas.alpha = 1;
    }
}
