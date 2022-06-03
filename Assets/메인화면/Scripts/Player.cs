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
		// Left, aŰ�� ������ x = -1
		// Right, dŰ�� ������ x = 1
		// �ƹ�Ű�� ������ ������ x = 0
		float x = Input.GetAxisRaw("Horizontal");
		// Down, sŰ�� ������ y = -1
		// Up, wŰ�� ������ y = 1
		// �ƹ�Ű�� ������ ������ y = 0
		float y = Input.GetAxisRaw("Vertical");

		// �̵����� ����
		moveDirection = new Vector3(x, y, 0);

		// �̵�/ȸ��/ũ�⸦ �����ϴ� "Transform" ������Ʈ�� �����Ͽ� ������Ʈ �̵�
		// ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
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


/*	1. Awake() �Լ����� �̵� ���� (1ȸ ȣ��)
 * 	private void Awake()
	{
		// �̵�/ȸ��/ũ�⸦ �����ϴ� "Transform" ������Ʈ�� �����Ͽ� ������Ʈ �̵�
		// ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
		transform.position = transform.position + new Vector3(1, 0, 0) * 1;
	}
 */
/*	2. ������� ��� ǥ��
 *	private void Awake()
	{
		// �̵�/ȸ��/ũ�⸦ �����ϴ� "Transform" ������Ʈ�� �����Ͽ� ������Ʈ �̵�
		// ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
		//transform.position = transform.position + new Vector3(1, 0, 0) * 1;
		//transform.position += new Vector3(1, 0, 0) * 1;
		transform.position += Vector3.right * 1;
	}
 */
/*	3. Update() �Լ����� �̵� ���� (�� ������ ȣ��)
 *	private void Update()
	{
		// �̵�/ȸ��/ũ�⸦ �����ϴ� "Transform" ������Ʈ�� �����Ͽ� ������Ʈ �̵�
		// ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
		transform.position += Vector3.right * 1 * Time.deltaTime;
	}
 */
/*	4. Input.GetAxisRaw()
 *	private	float	moveSpeed = 5.0f;
	private	Vector3	moveDirection;

	private void Update()
	{
		// Left, aŰ�� ������ x = -1
		// Right, dŰ�� ������ x = 1
		// �ƹ�Ű�� ������ ������ x = 0
		float x = Input.GetAxisRaw("Horizontal");
		// Down, sŰ�� ������ y = -1
		// Up, wŰ�� ������ y = 1
		// �ƹ�Ű�� ������ ������ y = 0
		float y = Input.GetAxisRaw("Vertical");

		// �̵����� ����
		moveDirection = new Vector3(x, y, 0);
		
		// �̵�/ȸ��/ũ�⸦ �����ϴ� "Transform" ������Ʈ�� �����Ͽ� ������Ʈ �̵�
		// ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
		transform.position += moveDirection * moveSpeed * Time.deltaTime;
	}
 */
/*	����. Input.GetKey()
 *	private	float	moveSpeed = 5.0f;
	private	Vector3	moveDirection;

	private void Update()
	{
		// �� �����Ӹ��� Update()�� ���۵� �� �̵� ������ (0, 0, 0)���� ����
		moveDirection = Vector3.zero;	// new Vector3(0, 0, 0)

		// Up/Down/Left/Right ����Ű�� ������ �� �̵�����(moveDirection)�� ���� �� ����
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

		// �̵�/ȸ��/ũ�⸦ �����ϴ� "Transform" ������Ʈ�� �����Ͽ� ������Ʈ �̵�
		// ���ο� ��ġ = ���� ��ġ + (���� * �ӵ�)
		transform.position += moveDirection * moveSpeed * Time.deltaTime;
	}
 */

