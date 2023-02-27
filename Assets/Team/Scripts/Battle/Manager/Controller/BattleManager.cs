using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public partial class BattleManager : Singleton<BattleManager>
{
    public BattleSO FakeInput_BattleSo;
    public PlayerBattleController PlayerBattleControler;
    
    private BattleSO currentBattleSO;
    
    private bool isPaused = false;
    public bool IsPaused => isPaused;
    public UnityAction<bool> onPause;
    
    private bool isGameOver = false;
    public bool IsGameOver => isGameOver;
    public UnityAction onGameOver;
        
    void Start()
    {
        // Fake Input Battle Data
        StartBattle(FakeInput_BattleSo);
    }

    public void StartBattle(BattleSO SO)
    {
        currentBattleSO = SO;
        
        // fake PlayerBattle Data
        // Todo: create PlayerBattleData from PlayerData
        PlayerBattleControler.Init(new PlayerBattleData());

        // Fake Create Spawner
        CreateSpawner();
        
        PauseGame(false);
    }

    public void GameOver()
    {
        isGameOver = true;
        onGameOver?.Invoke();
    }
    
    // UI Button or something.
    public void PauseGame(bool pause)
    {
        isPaused = pause;
        onPause?.Invoke(pause);
    }
}
