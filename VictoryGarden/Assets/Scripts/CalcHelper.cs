using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcHelper {

	public static double CalculateProduceCost(int produce)
	{
		return (GameData.All_Produce[produce].TotalOwned * GameData.All_Produce[produce].TotalOwned);
	}

}
