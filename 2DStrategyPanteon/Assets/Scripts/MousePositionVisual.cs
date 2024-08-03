using UnityEngine;

public class MousePositionVisual : MonoBehaviour
{
  [SerializeField] private GameObject mouseIndicator;
  [SerializeField] private MousePositionInput mouseInput;

  private void Update() {
    Vector3 mousePosition = mouseInput.GetLastMousePosition();
    mouseIndicator.transform.position = mousePosition;
  }
}
