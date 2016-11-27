using UnityEngine;
using System.Collections;

//ssc
public class PlayerController: MonoBehaviour 
{	
	CharacterController controller;
	Animator animator;
	
	Vector3 moveDirection = Vector3.zero;

	public float gravity;
	public float speedZ;
	public float speedJump;

	void Start ()
	{
		// 필요한 컴포넌트를 자동 취득
		controller = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
	}
	
	void Update ()
	{
		// 디버그 용
		if (controller.isGrounded) {
			if (Input.GetAxis ("Vertical") > 0.0f) {
				moveDirection.z = Input.GetAxis ("Vertical") * speedZ;
			} else {
				moveDirection.z = 0;
			}
			transform.Rotate (0, Input.GetAxis ("Horizontal") * 3, 0);
		}


		// 중력만큼의 힘을 매 프레임 추가
		moveDirection.y -= gravity * Time.deltaTime;
		
		// 이동 실행
		Vector3 globalDirection = transform.TransformDirection(moveDirection);
		controller.Move(globalDirection * Time.deltaTime);
		
		if(controller.isGrounded) moveDirection.y = 0;
		
		// 속도가 0 이상이면 달리고 있는 플래그를 true로 한다
		animator.SetBool("w", moveDirection.z > 0.0f);
	}

}