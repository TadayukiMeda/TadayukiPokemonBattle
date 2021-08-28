﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "ScriptableObjects/PokemonSkill")]
public class Skill : ScriptableObject
{
    public string name; 
    public PokemonType type;
    public int power;
    public void UseSkill(UnitBese unit)
    {
        Debug.Log(unit.info.name+"no,"+name);
        MessageManager.Instance.SetMessage(unit.info.name + "no," + name, 2);
    }

}
