using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnit : UnitBase
{
    public Transform skillButtonParent;
    // Start is called before the first frame update
    protected override void Start()
    {
        calling = "ポケモン使い";
        base.Start();
        SetSkillButton();
    }
    protected override void SetUI()
    {
        
        base.SetUI();
    }
    public void SetSkillButton()
    {
        for (int i = 0; i < skillButtonParent.childCount; i++)
        {
            Button button = skillButtonParent.GetChild(i).GetComponent<Button>();
            Skill skill = info.skillList[i];
            button.image.color = skill.type.color;
            button.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = skill.name;
            button.onClick.AddListener(
                () =>
                {
                   skill.UseSkill(this);
                    //BattleManager.Instance.BattleProcess();
                }
            );
        }
    }
    public void SetSkillButtonEnabled(bool enabled)
    {
        for(int i = 0; i < skillButtonParent.childCount; i++)
        {
            skillButtonParent.GetChild(i).GetComponent<Button>().interactable = enabled;
        }
    }
}
