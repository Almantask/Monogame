using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class Quest : MonoBehaviour
{
	public string name;
	public string description;
	public List<Objective> objectives;
	public string reward;
	public Sprite rewardIcon;
	public QuestType questType;
	public QuestStatus questStatus;

	void Start()
	{
		InitialiseObjectives ();
	}

	private void InitialiseObjectives()
	{
		for (int index = 0; index < objectives.Count; index++) 
		{
			objectives[index].Initialise (this);
		}
	}

	public void UpdateQuest()
	{
		for (int index = 0; index < objectives.Count; index++) 
		{
			Objective objective = objectives [index];

			if (!objective.IsCompleted ()) 
			{
				return;
			}
		}

		Debug.Log ("Quest Complete");
	}
}

public enum QuestType
{
	MAIN,
	SECONDARY,
	COMPANION
}

public enum QuestStatus
{
	INPROGRESS,
	COMPLETED,
	FAILED
}

