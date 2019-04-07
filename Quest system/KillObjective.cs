using UnityEngine;
using System.Collections;

public class KillObjective : Objective
{
	private int currentKillCount;
	public int maxKillCount;
	public MobType mobType;

	public void UpdateObjective()
	{
		currentKillCount++;

		Debug.Log ("You have killed " + currentKillCount + "/" + maxKillCount);

		if(currentKillCount >= maxKillCount)
		{
			currentKillCount = maxKillCount;
			objectiveStatus = ObjectiveStatus.COMPLETED;
			base.UpdateObjective ();
			Debug.Log (mobType == MobType.BEAR ? "Bear objective completed" : "Wolf objective completed");

		}
		else
		{
			objectiveStatus = ObjectiveStatus.INPROGRESS;
		}
	}
}

public enum MobType
{
	WOLF,
	BEAR,
	SPIDER
}

