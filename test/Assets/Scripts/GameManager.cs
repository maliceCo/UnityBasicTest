using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerManager player;
    public UIManager uiManager;
    public EnemyManager enemyManager;

    private void Start()
    {
        player.OnDead += OnDeadPlayer;
    }

    private void OnDeadPlayer()
    {
        uiManager.Show(true);
        enemyManager.Stop();
    }
}