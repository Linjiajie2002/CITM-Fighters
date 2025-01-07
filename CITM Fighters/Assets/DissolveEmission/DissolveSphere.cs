using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DissolveSphere : MonoBehaviour
{

    Material[] mats;
    public float dissolveSpeed = 0.5f; // 溶解速度
    private float dissolveAmount = 0f; // 当前溶解值
    private bool isDissolving = true;  // 控制是否继续溶解
    private bool isWidthSet = false;   // 是否已设置 _DissolveWidth

    public CharacterController _playerController;
    private void Start()
    {
        // 获取所有材质
        mats = GetComponent<Renderer>().materials;
        _playerController = FindObjectOfType<CharacterController>();
    }

    private void Update()
    {
        // 在 Update 中只执行一次 _DissolveWidth 的设置
        if (_playerController.gameFinish && _playerController.isDie)
        {
            foreach (Material mat in mats)
            {
                mat.SetFloat("_DissolveWidth", 0.05f); // 设置溶解宽度为 0.05
            }
            isWidthSet = true; // 确保只执行一次


            if (isDissolving)
            {
                // 增加溶解值，直到达到 1
                dissolveAmount += Time.deltaTime * dissolveSpeed;
                dissolveAmount = Mathf.Clamp01(dissolveAmount);

                // 更新材质中的溶解值
                foreach (Material mat in mats)
                {
                    mat.SetFloat("_DissolveAmount", dissolveAmount);
                }

                // 检查溶解是否完成
                if (dissolveAmount >= 1f)
                {
                    isDissolving = false;
                    OnDissolveComplete();
                }
            }
        }
    }

    private void OnDissolveComplete()
    {
        // 溶解完成后的行为
        Debug.Log("Dissolve completed!");
        Destroy(gameObject); // 示例：销毁对象
    }
}
