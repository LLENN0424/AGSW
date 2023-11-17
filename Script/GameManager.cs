using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int totalEnemies = 10; // ゲーム内の総敵数（適宜変更してください）
    private int defeatedEnemies = 0; // 倒された敵の数

    // 敵が倒された時に呼ばれる関数
    public void EnemyDefeated()
    {
        defeatedEnemies++;

        // 倒された敵の数が総敵数に達した場合、ゲーム終了
        if (defeatedEnemies >= totalEnemies)
        {
            // ゲームクリアシーンに遷移（適宜シーン名を変更してください）
            SceneManager.LoadScene("GameClearScene");
        }
    }
}
