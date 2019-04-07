using UnityEngine;
using System.Collections;

public class KillWolf : MonoBehaviour 
{

	public QuestManager questManager;
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.J)) 
		{
			foreach (Quest quest in questManager.currentQuests) 
			{
				foreach (Objective objective in quest.objectives) 
				{
					if (!objective is KillObjective) 
					{
						continue;
					}
						KillObjective killObjective = (KillObjective)objective;
					if (killObjective.mobType == MobType.WOLF)
					{
						killObjective.UpdateObjective ();
					}
				}
			}
		}
	}
}