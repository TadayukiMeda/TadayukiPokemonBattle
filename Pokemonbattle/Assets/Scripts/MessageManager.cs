using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MessageManager :SingletonMonoBehaviour<MessageManager>
{
    public Text message;
    private void Start()
    {
        message.DOText("こんばんは、いつか佐藤さんにポケモンのAIを作ってもらいます",3).SetEase(Ease.Linear);
    }
    public void SetMessage(string text,float time)
    {
        message.text = "";
        message.DOText(text, time).SetEase(Ease.Linear);
    }
}
