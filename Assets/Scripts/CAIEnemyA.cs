using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAIEnemyA : CAIBase
{
	public override void Execute()
	{
		Move();
	}

	private float m_angle = 0.0f;

	private void Move()
	{
		transform.position = new Vector3(Mathf.Sin(m_angle) * 5.0f,
										 transform.position.y,
										 transform.position.z);

		m_angle += 0.1f;
	}
}
