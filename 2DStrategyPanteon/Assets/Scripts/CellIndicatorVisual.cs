using UnityEngine;

public class CellIndicatorVisual : MonoBehaviour {
  [SerializeField] private GameObject cellIndicator;
  [SerializeField] private MousePositionInput mouseInput;
  [SerializeField] private Grid grid;

  private void Update() {
    Vector3 mousePosition = mouseInput.GetLastMousePosition();
    Vector3Int gridPosition = grid.WorldToCell(mousePosition);
    cellIndicator.transform.position = grid.CellToWorld(gridPosition);
  }
}