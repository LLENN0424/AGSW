using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffect : MonoBehaviour
{
    public Material redScreenMaterial; // �Ԃ���ʂ�\������}�e���A��
    private float damageDuration = 0.1f; // �_���[�W�G�t�F�N�g�̕\�����ԁi�b�j

    // Start is called before the first frame update
    void Start()
    {
        // �Ԃ���ʂ��\���ɂ���
        redScreenMaterial.color = new Color(1f, 1f, 1f, 0f);
    }

    public void ApplyDamageEffect()
    {
        // �Ԃ���ʂ�\�����āA��u�����Ԃ�����
        redScreenMaterial.color = new Color(1f, 0f, 0f, 1f);
        Invoke("DisableDamageEffect", damageDuration); // damageDuration�b��ɃG�t�F�N�g�𖳌��ɂ���
    }

    private void DisableDamageEffect()
    {
        // �Ԃ���ʂ��\���ɂ���
        redScreenMaterial.color = new Color(1f, 1f, 1f, 0f);
    }
}
