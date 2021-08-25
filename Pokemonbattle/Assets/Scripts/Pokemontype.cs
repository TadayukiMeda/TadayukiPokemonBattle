using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Type", menuName = "ScriptableObjects/PokemonType")]

public class Pokemontype : ScriptableObject
{

    public　Ptype Mytype;
    

    [SerializeField,Header("苦手なタイプ")] List<Ptype> nigate;
         
}


