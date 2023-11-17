using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int totalEnemies = 10; // �Q�[�����̑��G���i�K�X�ύX���Ă��������j
    private int defeatedEnemies = 0; // �|���ꂽ�G�̐�

    // �G���|���ꂽ���ɌĂ΂��֐�
    public void EnemyDefeated()
    {
        defeatedEnemies++;

        // �|���ꂽ�G�̐������G���ɒB�����ꍇ�A�Q�[���I��
        if (defeatedEnemies >= totalEnemies)
        {
            // �Q�[���N���A�V�[���ɑJ�ځi�K�X�V�[������ύX���Ă��������j
            SceneManager.LoadScene("GameClearScene");
        }
    }
}
