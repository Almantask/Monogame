using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour 
{
	public QuestManager questManager;
	public GameObject[] quests;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.G)) 
		{
			questManager.AddQuest (quests [0].GetComponent<Quest>());
		}
			
	}
}
