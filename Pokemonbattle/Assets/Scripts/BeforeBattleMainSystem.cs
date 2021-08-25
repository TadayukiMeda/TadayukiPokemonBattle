using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeforeBattleMainSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveBattleScene()
    {
        SceneManager.LoadScene("BattleScene");
    }
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
