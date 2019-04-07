using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestManager : MonoBehaviour 
{
	internal List<Quest> currentQuests = new List<Quest>(); 

	public void AddQuest(Quest quest)
	{
		currentQuests.Add (quest);
	}
}
