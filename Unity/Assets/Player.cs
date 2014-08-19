using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour {
	
	public Rigidbody2D cRigidbody2D
	{
		get
		{
			if(!_cRigidbody2D)
				_cRigidbody2D = rigidbody2D;
			return _cRigidbody2D;
		}
	}
	Rigidbody2D _cRigidbody2D;
	
	public float moveSpeed = 5;
	
	void FixedUpdate()
	{
		Move();
	}
	
	void Move()
	{
		cRigidbody2D.velocity = new Vector2(moveSpeed * Input.GetAxisRaw("Horizontal"),
		                                    cRigidbody2D.velocity.y);
	}
}