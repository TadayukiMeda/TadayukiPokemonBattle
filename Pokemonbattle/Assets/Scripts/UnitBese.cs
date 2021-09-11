using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitBase : MonoBehaviour
{
    public PokemonInfo info;

    public InfoUI infoUI;


    public bool IsDead { get { return hp <= 0; } }

    protected AbilityStruct statusAbilityStruct;
    protected int hp;

    public string calling;
    [HideInInspector] public Skill currentSkill;
    public AbilityStruct nowAbilityStruct
    {
        get
        {
            return info.ability * statusAbilityStruct;
        }
    }
    // Start is called before the first frame update
    protected virtual void Start()
    {
        statusAbilityStruct = new AbilityStruct(0, 0, 0, 0, 0, 0);
        hp = info.ability.hp;
        SetUI();
    }
    protected virtual void OnValidate()
    {
        SetUI();
    }
    protected virtual void SetUI()
    {
        GetComponent<Image>().sprite = info.image;
        infoUI.nameText.text = info.name;

    }
    public void DecreaseHP(int decreaseValue)
    {
        SetHP(hp - decreaseValue);
    }
    public void SetHP(int hp)
    {
        this.hp = hp;
        if (IsDead)
        {
            hp = 0;
        }
        infoUI.SetHpPersent((float)hp / (float)info.ability.hp);
    }




}
