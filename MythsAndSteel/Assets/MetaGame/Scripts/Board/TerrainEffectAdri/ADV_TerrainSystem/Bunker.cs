using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunker : TerrainParent
{
    public void Awake()
    {
        GetComponentInParent<TileScript>().AddEffectToList(MYthsAndSteel_Enum.TerrainType.Point_de_ressource);
        GetComponentInParent<TileScript>().ResourcesCounter = 2;
    }

    public override void FirstUnitOnCase(UnitScript Unit)
    {
        if (Unit != null)
        {
            Debug.LogWarning("Deux ressources supp. car vous �tes arriv�s en premier sur le bunker. Pr�voir un rendu visuel de r�cup�ration ?");
            if (Unit.UnitSO.IsInRedArmy)
            {
                GetComponentInParent<TileScript>().RemoveRessources(2, 1);
            }
            else
            {
                GetComponentInParent<TileScript>().RemoveRessources(2, 2); 
            }
        }
        base.FirstUnitOnCase(Unit);
    }
}
