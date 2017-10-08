using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAIEnemyB : CAIBase
{
	private Rigidbody2D m_rigid;
	private Vector2 m_vel = new Vector2(0, 5);
	private int count = 0;
	public void Start()
	{
		m_rigid = GetComponent<Rigidbody2D>();
	}
	public override void Execute()
	{
		count++;
		if (!(count>=120)) return;

		m_rigid.velocity = m_vel;
		count = 0;
	}
}