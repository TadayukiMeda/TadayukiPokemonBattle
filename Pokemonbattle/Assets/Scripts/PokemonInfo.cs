using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Info", menuName = "ScriptableObjects/PokemonInfo")]
public class PokemonInfo : ScriptableObject
{
    public string name;
    public Ptype type;
    public AbilityStruct ability;
    public Sprite image;
    public Skill[] skillList;


}
