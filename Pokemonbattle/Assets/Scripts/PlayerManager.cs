using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : SingletonMonoBehaviour<PlayerManager>
{
    // Start is called before the first frame update
    [SerializeField] PokemonInfo[] pokemonKindArray;
    private UnitBase player, otherplayer;
    public void AddPlayer(UnitBase unit)
    {
        player = unit;
     //   player.info = pokemonKindArray[Random.Range(0, pokemonKindArray.Length)]
    }
    public void AddOtherPlayer(UnitBase unit)
    {
        otherplayer = unit;
      //  otherplayer.info = pokemonKindArray[Random.Range(0,pokemonKindArray.Length)];
    }
    public UnitBase GetPlayer()
    {
        return player;
    }
    public UnitBase GetOtherPlayer()
    {
        return otherplayer;
    }
    public UnitBase GetFirstUnit()
    {
        if(player.nowAbilityStruct.speed > otherplayer.nowAbilityStruct.speed) return player;
        else return otherplayer;
    }
    public UnitBase  GetSecondUnit()
    {
        if(player.nowAbilityStruct.speed <= otherplayer.nowAbilityStruct.speed) return player;
        else return otherplayer;
    }
}

