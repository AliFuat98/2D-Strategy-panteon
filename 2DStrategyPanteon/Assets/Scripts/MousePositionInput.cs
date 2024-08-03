using UnityEngine;

public class MousePositionInput : MonoBehaviour {
  [SerializeField] private LayerMask placementLayerMask;

  private Vector3 lastMousePosition;
  private Camera mainCamera;

  private void Awake() {
    mainCamera = Camera.main;
  }

  private void Update() {
    lastMousePosition = SetSelectedMapPosition();
  }

  private Vector3 SetSelectedMapPosition() {
    Vector3 mousePos = Input.mousePosition;
    // Convert screen point to world point
    Vector3 worldPos = mainCamera.ScreenToWorldPoint(mousePos);
    Vector2 worldPos2D = new(worldPos.x, worldPos.y);

    RaycastHit2D hit = Physics2D.Raycast(worldPos2D, Vector2.zero, Mathf.Infinity, placementLayerMask);
    if (hit.collider != null) {
      lastMousePosition = hit.point;
    }

    return lastMousePosition;
  }

  public Vector3 GetLastMousePosition() {
    return lastMousePosition;
  }
}