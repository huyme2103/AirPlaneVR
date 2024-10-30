using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorAnimationController : MonoBehaviour
{
    public Animator doorAnimator;
    private bool isOpen = false; // Trạng thái cửa

    // Hàm này sẽ được gọi khi OnSelectEntered được kích hoạt
    public void ToggleDoor()
    {
        // Đổi trạng thái cửa
        isOpen = !isOpen;

        // Cập nhật parameter isOpen trong Animator
        doorAnimator.SetBool("isOpen", isOpen);

       
    }
}
