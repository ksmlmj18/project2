using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private float moveSpeed = 5.0f;
	private Vector3 moveDirection;
	bool ischange;
	public GameObject G1;
	public gameManager GameManager;

	private void Start()
	{
		G1.gameObject.SetActive(false);
	}

	private void Update()
	{
		// Left, a키를 누르면 x = -1
		// Right, d키를 누르면 x = 1
		// 아무키도 누르지 않으면 x = 0
		float x = Input.GetAxisRaw("Horizontal");
		// Down, s키를 누르면 y = -1
		// Up, w키를 누르면 y = 1
		// 아무키도 누르지 않으면 y = 0
		float y = Input.GetAxisRaw("Vertical");

		// 이동방향 설정
		moveDirection = new Vector3(x, y, 0);

		// 이동/회전/크기를 제어하는 "Transform" 컴포넌트를 조작하여 오브젝트 이동
		// 새로운 위치 = 현재 위치 + (방향 * 속도)
		transform.position += moveDirection * moveSpeed * Time.deltaTime;
	}
	void OnTriggerEnter2D(Collider2D colision)
	{
		if (colision.gameObject.tag == "Item")
		{
			colision.gameObject.SetActive(false);

			GameManager.sp += 100;

		}
		else if (colision.tag == "Box")
		{
			G1.gameObject.SetActive(true);
		}


	}

	
}


/*	1. Awake() 함수에서 이동 구현 (1회 호출)
 * 	private void Awake()
	{
		// 이동/회전/크기를 제어하는 "Transform" 컴포넌트를 조작하여 오브젝트 이동
		// 새로운 위치 = 현재 위치 + (방향 * 속도)
		transform.position = transform.position + new Vector3(1, 0, 0) * 1;
	}
 */
/*	2. 연산식의 축약 표현
 *	private void Awake()
	{
		// 이동/회전/크기를 제어하는 "Transform" 컴포넌트를 조작하여 오브젝트 이동
		// 새로운 위치 = 현재 위치 + (방향 * 속도)
		//transform.position = transform.position + new Vector3(1, 0, 0) * 1;
		//transform.position += new Vector3(1, 0, 0) * 1;
		transform.position += Vector3.right * 1;
	}
 */
/*	3. Update() 함수에서 이동 구현 (매 프레임 호출)
 *	private void Update()
	{
		// 이동/회전/크기를 제어하는 "Transform" 컴포넌트를 조작하여 오브젝트 이동
		// 새로운 위치 = 현재 위치 + (방향 * 속도)
		transform.position += Vector3.right * 1 * Time.deltaTime;
	}
 */
/*	4. Input.GetAxisRaw()
 *	private	float	moveSpeed = 5.0f;
	private	Vector3	moveDirection;

	private void Update()
	{
		// Left, a키를 누르면 x = -1
		// Right, d키를 누르면 x = 1
		// 아무키도 누르지 않으면 x = 0
		float x = Input.GetAxisRaw("Horizontal");
		// Down, s키를 누르면 y = -1
		// Up, w키를 누르면 y = 1
		// 아무키도 누르지 않으면 y = 0
		float y = Input.GetAxisRaw("Vertical");

		// 이동방향 설정
		moveDirection = new Vector3(x, y, 0);
		
		// 이동/회전/크기를 제어하는 "Transform" 컴포넌트를 조작하여 오브젝트 이동
		// 새로운 위치 = 현재 위치 + (방향 * 속도)
		transform.position += moveDirection * moveSpeed * Time.deltaTime;
	}
 */
/*	번외. Input.GetKey()
 *	private	float	moveSpeed = 5.0f;
	private	Vector3	moveDirection;

	private void Update()
	{
		// 매 프레임마다 Update()가 시작될 때 이동 방향을 (0, 0, 0)으로 설정
		moveDirection = Vector3.zero;	// new Vector3(0, 0, 0)

		// Up/Down/Left/Right 방향키를 눌렀을 때 이동방향(moveDirection)에 방향 값 설정
		if ( Input.GetKey(KeyCode.UpArrow) )
		{
			moveDirection += Vector3.up;
		}
		else if ( Input.GetKey(KeyCode.DownArrow) )
		{
			moveDirection += Vector3.down;
		}
		if ( Input.GetKey(KeyCode.LeftArrow) )
		{
			moveDirection += Vector3.left;
		}
		else if ( Input.GetKey(KeyCode.RightArrow) )
		{
			moveDirection += Vector3.right;
		}

		// 이동/회전/크기를 제어하는 "Transform" 컴포넌트를 조작하여 오브젝트 이동
		// 새로운 위치 = 현재 위치 + (방향 * 속도)
		transform.position += moveDirection * moveSpeed * Time.deltaTime;
	}
 */

