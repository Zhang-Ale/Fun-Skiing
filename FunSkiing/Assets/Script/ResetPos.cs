using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    public LayerMask LayerMask;
    public BoxCollider boxCMid;

    public float Height;

    public GameObject parent;

    public RaycastHit hit;

    private void Start()
    {
        boxCMid = GetComponent<BoxCollider>();
    }

    void Update()
    {
        if (Physics.Raycast(boxCMid.transform.position, Vector3.down, out hit, Height, LayerMask))
        {
            Debug.DrawRay(transform.position, Vector2.down * Height, Color.green, 10);

            parent.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            parent.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(0, 0, 0), 90f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground")
        {
            parent.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            parent.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(0, 0, 0), 90f);
        }
    }

}
