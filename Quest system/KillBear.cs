using UnityEngine;
using System.Collections;

public class KillBear : MonoBehaviour 
{
	public QuestManager questManager;
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.F)) 
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
					if (killObjective.mobType == MobType.BEAR)
					{
						killObjective.UpdateObjective ();
					}
				}
			}
		}
	}
}

