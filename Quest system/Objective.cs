using UnityEngine;
using System.Collections;

public abstract class Objective : MonoBehaviour, IObjective
{
	public string name;
	public string description;
	protected ObjectiveStatus objectiveStatus;
	private Quest currentQuest;



	#region IObjective implementation
	public void UpdateObjective()
	{
		currentQuest.UpdateQuest ();
	}
	#endregion

	public void Initialise(Quest quest)
	{
		currentQuest = quest;
	}

	public bool IsCompleted()
	{
		return objectiveStatus == ObjectiveStatus.COMPLETED;
	}
}

public interface IObjective
{
	void UpdateObjective();
}

public enum ObjectiveStatus
{
	INPROGRESS,
	COMPLETED
}
