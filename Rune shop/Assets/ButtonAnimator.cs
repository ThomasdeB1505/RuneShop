using UnityEngine;

public class ButtonAnimator : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void OpenOrClose()
    {
        animator.SetBool("Open", !animator.GetBool("Open"));
    }
}
