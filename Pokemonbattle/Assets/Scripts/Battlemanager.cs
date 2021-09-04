using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Battlemanager : SingletonMonoBehaviour<Battlemanager>
{
    public IEnumerator battleIEnumerator;
    IEnumerator Start()
    {
        yield return null;
        // MessageManager.Instance.SetMessage($"{PlayerManager.Instance.GetOtherPlayer().info.pokemonName}が" + Environment.NewLine + "あらわれた!" + Environment.NewLine + $"攻撃をするんだ！");
    }
    public void BattleProcess()
    {
        battleIEnumerator = BattleProcessCoutine();
        StartCoroutine(battleIEnumerator);
    }
    private IEnumerator BattleProcessCoutine()
    {
        ((PlayerUnit)PlayerManager.Instance.GetPlayer()).SetSkillButtonEnabled(false);
        ((EnemyUnit)PlayerManager.Instance.GetOtherPlayer()).EnemyTurn();
        UnitBase firstUnit = PlayerManager.Instance.GetFirstUnit();
        UnitBase secondUnit = PlayerManager.Instance.GetSecondUnit();
        Func<UnitBase, UnitBase,YieldInstruction> attackAttack =(unit, taretUnit) =>
        {
            String massage = "";
            float waitTime = 1;
            Skill skill = unit.currentSkill;
            float randomValue = Random.Range(0.85f, 1f);
            float levelDamage = (50 * 2 /5)+2;

            float nonLevelDamage =skill.power;
            //switch(skill.attackType)
            {

            }
            return null;
        };
        yield return null;
    }
}
