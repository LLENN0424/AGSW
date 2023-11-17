using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffect : MonoBehaviour
{
    public Material redScreenMaterial; // 赤い画面を表示するマテリアル
    private float damageDuration = 0.1f; // ダメージエフェクトの表示時間（秒）

    // Start is called before the first frame update
    void Start()
    {
        // 赤い画面を非表示にする
        redScreenMaterial.color = new Color(1f, 1f, 1f, 0f);
    }

    public void ApplyDamageEffect()
    {
        // 赤い画面を表示して、一瞬だけ赤くする
        redScreenMaterial.color = new Color(1f, 0f, 0f, 1f);
        Invoke("DisableDamageEffect", damageDuration); // damageDuration秒後にエフェクトを無効にする
    }

    private void DisableDamageEffect()
    {
        // 赤い画面を非表示にする
        redScreenMaterial.color = new Color(1f, 1f, 1f, 0f);
    }
}
