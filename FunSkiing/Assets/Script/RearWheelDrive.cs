using UnityEngine;
using System.Collections;

public class RearWheelDrive : MonoBehaviour 
{
	private WheelCollider[] wheels;

	private Rigidbody rb;

	public float speed;
	public float slow;

	public float distToGround = .5f;
	public float maxTorque = 300;
	public float maxAngle = 30;
	public float frontSpeed = 30f;
	public float backSpeed = 5f;


	// here we find all the WheelColliders down in the hierarchy
	private void Start()
	{
		
		rb = GetComponent<Rigidbody>();
		
		wheels = GetComponentsInChildren<WheelCollider>();
		
	}
	public void Update()
	{
		//Jump();
		Move();

		/*if (IsGrounded() && Input.GetKeyDown(KeyCode.LeftShift))
		{
			rb.velocity = transform.forward * speed;
		}*/
		if (IsGrounded() && Input.GetKey(KeyCode.LeftShift))
		{
			speed += Time.deltaTime * slow;
			rb.velocity = -transform.forward;
		}
		
	}

	public void Move()
	{
		/*if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector3.forward * frontSpeed * Time.deltaTime);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(-Vector3.forward * backSpeed * Time.deltaTime);*/

		float torque = Input.GetAxis("Vertical");
		float angle = Input.GetAxis("Horizontal");

		foreach (WheelCollider wheel in wheels)
		{

			if (wheel.transform.localPosition.z < 0)
				wheel.motorTorque = torque * maxTorque * frontSpeed;

			if (wheel.transform.localPosition.z > 0)
				wheel.steerAngle = angle * maxAngle;

		}
	}
	public void Jump()
	{
		if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
		{
			float jumpVelocity = 25f;
			//rb.velocity = Vector3.up * jumpVelocity;
			rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
		}
	}

	public bool IsGrounded()
	{
		return Physics.Raycast(transform.position, Vector3.down + Vector3.left + Vector3.right, distToGround);
		
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Kid")
		{
			rb.velocity = transform.forward * speed * 5;
			
			//StartCoroutine(ResetSpeedAfterTime(2f));
		}
		/*else if (other.gameObject.tag == "Coach")
		{
			Destroy(this.gameObject);
		}*/
		
	}

	// Resets the speed variable back to the original value after a set amount of time
	/*private IEnumerator ResetSpeedAfterTime(float time)
	{
		time = 2f;
		yield return new WaitForSeconds(time);
		rb.velocity = transform.forward / speed; // the original speed value;
	    //speed = 10f; 
	}*/

}

