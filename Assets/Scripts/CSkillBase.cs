using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSkillBase {

	public virtual void Execute()
	{
		Debug.Log("Base.");
	}
}

public class CSkillA : CSkillBase
{
	public override void Execute()
	{
		Debug.Log("SkillA.");
	}
}

public class CSkillB : CSkillBase
{
	public override void Execute()
	{
		Debug.Log("SkillB.");
	}
}