using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnamyBase : MonoBehaviour {
	#region メンバ変数
	private float m_helthPoint;
	private float m_attackPoint;
	private List<CSkillBase> m_skills = new List<CSkillBase>();
	#endregion

	#region Monobehavior基底コールバック
	// Use this for initialization
	void Start () {
		m_skills.Add(new CSkillA());
		m_skills.Add(new CSkillB());

		foreach(var skill in m_skills)
		{
			skill.Execute();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	#endregion
}
