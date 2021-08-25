using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMainSystem : MonoBehaviour
{
    public Unit player;
    public Unit enemy;
    public GameObject Label;
    public Text battleResultText;
    public Text battleLogText;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Battle()
    {
        Unit FirstAttack;
        Unit SecoundAttack;



        bool firstPlayerAttackFlag = false;
        if (player.speed >= enemy.speed)
        {
            FirstAttack = player;
            SecoundAttack = enemy;
            firstPlayerAttackFlag = true;
        }
        else
        {
            FirstAttack = enemy;
            SecoundAttack = player;
        }



        int damage;
        if (FirstAttack.hp > 0)
        {
            damage = FirstAttack.Attack(SecoundAttack);
            if(firstPlayerAttackFlag == true)
            {
                battleLogText.text += "自分の攻撃！！\n";
                battleLogText.text += $"敵に{damage}のダメージ！！\n";
            }
            else
            {
                battleLogText.text += "敵の攻撃！！\n";
                battleLogText.text += $"自分に{damage}のダメージ！！\n";
            }
        }


        if (SecoundAttack.hp > 0)
        {
            damage = SecoundAttack.Attack(FirstAttack);
            if (firstPlayerAttackFlag == false)
            {
                battleLogText.text += "自分の攻撃！！\n";
                battleLogText.text += $"敵に{damage}のダメージ！！\n";
            }
            else
            {
                battleLogText.text += "敵の攻撃！！\n";
                battleLogText.text += $"自分に{damage}のダメージ！！\n";
            }

        }
        
        player.hpSlider.value = player.hp;
        enemy.hpSlider.value = enemy.hp;

        if (player.hp == 0)
        {
            Label.SetActive(true);
            battleResultText.text = "あなたの負け";
            Button.SetActive(false);
        }
        if (enemy.hp == 0)
        {
            Label.SetActive(true);
            battleResultText.text = "あなたの勝ち";
            Button.SetActive(false);
        }
        
    }

}
