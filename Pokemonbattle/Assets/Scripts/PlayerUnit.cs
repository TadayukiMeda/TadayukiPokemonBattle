using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnit : UnitBese
{
    public Transform skillButtonParent;
    // Start is called before the first frame update
    protected override void Start()
    {
        calling = "ポケモン使い";

        base.Start();

    }
    protected override void SetUI()
    {
        
        base.SetUI();
        SetSkillButton();
    }
    public void SetSkillButton()
    {
        for (int i = 0; i < skillButtonParent.childCount; i++)
        {
            Button button = skillButtonParent.GetChild(i).GetComponent<Button>();
            Skill skill = info.skillList[i];
            button.image.color = TypeManager.Instance.GetComponet(skill.type);
            button.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = skill.name;
            button.onClick.AddListener(
                () =>
                {
                    skill.UseSkill(this);
                    BattleManager.Instance.BattleProcess();
                }
            );
        }
    }
    public void setSkillButtonEnabled(bool enabled)
    {
        for(int i = 0; i < skillButtonParent.childCount; i++)
        {
            skillButtonParent.GetChild(i).GetComponent<Button>().interactable = enabled;
        }
    }
}
