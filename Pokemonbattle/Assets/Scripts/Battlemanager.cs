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
        //MessageManager.Instance.SetMessage($"{PlayerManager.Instance.GetOtherPlayer().info.name}が" + Environment.NewLine + "あらわれた!" + Environment.NewLine + $"攻撃をするんだ！");
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
        Func<UnitBase, UnitBase, YieldInstruction> attackAction = (unit, targetUnit) =>
          {
              String message = "";
              float waitTime = 1;
              Skill skill = unit.currentSkill;
              float randomValue = Random.Range(0.85f, 1f);
              float levelDamage = (50 * 2 / 5) + 2;

              float nonLevelDamage = skill.power;
              switch (skill.attackType)
              {
                  case AttackType.physics:
                      nonLevelDamage *= (unit.nowAbilityStruct.physicsAttack / targetUnit.nowAbilityStruct.physicsGuard) / 50f;

                      break;
                  case AttackType.special:
                      nonLevelDamage *= (unit.nowAbilityStruct.specialAttack / targetUnit.nowAbilityStruct.specialGuard) / 50f;
                      break;
              }
              nonLevelDamage += 2;

              float damageValue = levelDamage * nonLevelDamage * randomValue;
              targetUnit.DecreaseHP((int)damageValue);
              message = (
              $"{unit.calling}の{unit.info.name}の" + Environment.NewLine + $"{(int)damageValue}のダメージ！");
              if (targetUnit.IsDead)
              {
                  message += Environment.NewLine + $"{targetUnit.calling}の{targetUnit.info.name}はたおれた！" + Environment.NewLine + $"{unit.info.name}のかち!";
                  MessageManager.Instance.SetMessage(message, 1.5f);
                  BattleFinished();
              }
              MessageManager.Instance.SetMessage(message);
              return new WaitForSeconds(waitTime);
          };
        yield return attackAction(firstUnit, secondUnit);
        yield return attackAction(secondUnit, firstUnit);
        MessageManager.Instance.SetMessage("攻撃をするんだ！" + Environment.NewLine + Environment.NewLine, .5f);
        yield return new WaitForSeconds(.5f);
        ((PlayerUnit)PlayerManager.Instance.GetPlayer()).SetSkillButtonEnabled(true);
    }
    public void BattleFinished()
    {
        StopCoroutine(battleIEnumerator);
        ((PlayerUnit)PlayerManager.Instance.GetPlayer()).SetSkillButtonEnabled(false);
        StartCoroutine(SceneReloaded());
    }

    private IEnumerator SceneReloaded()
    {
        yield return new WaitForSeconds(1.5f);
        MessageManager.Instance.SetMessage("5秒後にゲームをリスタートします" + Environment.NewLine, 0.5f);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
