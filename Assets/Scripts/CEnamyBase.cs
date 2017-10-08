using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEnamyBase : MonoBehaviour {
	#region メンバ変数
	private float m_helthPoint;
	private float m_attackPoint;
	private List<CSkillBase> m_skills = new List<CSkillBase>();
	private List<CAIBase> m_AIs = new List<CAIBase>();
	private int i = 0;
	private int count = 0;
	#endregion

	#region Monobehavior基底コールバック
	// Use this for initialization
	void Start () {
		m_skills.Add(new CSkillA());
		m_skills.Add(new CSkillB());

		m_AIs.Add(GetComponent<CAIEnemyA>());
		m_AIs.Add(GetComponent<CAIEnemyB>());

		foreach (var skill in m_skills)
		{
			skill.Execute();
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		m_AIs[i].Execute();
		if (count >= 300 && i == 0)
		{
			i++;
		}
		count++;
	}
	#endregion
}
