using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : UnitBase
{
    protected override void Start()
    {
        calling = "ポケモン使い";

        base.Start();

    }
    public void EnemyTurn()
    {
        info.skillList[Random.Range(0, info.skillList.Length)].UseSkill(this);
    }
    // Start is called before nthe first frame update
   

    // Update is called once per frame
  
}
