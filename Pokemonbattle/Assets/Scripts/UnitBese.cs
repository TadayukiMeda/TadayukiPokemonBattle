using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitBese : MonoBehaviour
{
    public PokemonInfo info;
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
            
    }

}
