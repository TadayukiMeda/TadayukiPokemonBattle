using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "ScriptableObjects/PokemonSkill")]
public class Skill : ScriptableObject
{
    public string name; 
    public Ptype type;
    public int power;
    

}
