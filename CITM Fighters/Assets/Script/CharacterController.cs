using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private string currentAnimation = "";

    void Start()
    {
        animator = GetComponent<Animator>();
        ChangeAnimation("idle");
    }

    void Update()
    {
        HandleActions();
        HandleAnimationCompletion();
    }

    private void HandleActions()
    {
        // ʾ�������� N ������ WalkFront ����
        if (Input.GetKeyDown(KeyCode.N))
        {
            ChangeAnimation("atak");
        }

        // ʾ�������� J ������ QuickAttack ����
        if (Input.GetKeyDown(KeyCode.J))
        {
            ChangeAnimation("walkfront");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeAnimation("idle");
        }
    }

    private void HandleAnimationCompletion()
    {
        // ��ȡ��ǰ����״̬
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // �������������ϲ��Ҳ��� Idle ״̬���л��� Idle
        if (stateInfo.normalizedTime >= 1.0f && !stateInfo.IsName("idle"))
        {
            ChangeAnimation("idle");
        }
    }

    private void ChangeAnimation(string animation, float crossfade = 0.2f)
    {
        if (currentAnimation != animation)
        {
            currentAnimation = animation;
            animator.CrossFade(animation, crossfade);
        }
    }
}
