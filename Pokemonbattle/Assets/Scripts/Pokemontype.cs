using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Type", menuName = "ScriptableObjects/PokemonType")]

public class PokemonType : ScriptableObject
{

    public　Ptype mytype;
    public Color color;
    

    [SerializeField,Header("苦手なタイプ")] List<PokemonType> weak;
    [SerializeField, Header("得意なタイプ")] List<PokemonType> strong;

}


