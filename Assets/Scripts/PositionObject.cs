using UnityEngine;

public class PositionObject : MonoBehaviour
{
    public Camera mainCamera; // �������� ������
    public RectTransform canvasRectTransform; // RectTransform Canvas
    public Vector3 anchorPosition; // ������� ������ Canvas (��������������� ���������� �� 0 �� 1)

    private void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        // �������� ������� Canvas
        Vector2 canvasSize = canvasRectTransform.sizeDelta;

        // ������������ ������� � ��������
        Vector2 targetPosition = new Vector2(canvasSize.x * anchorPosition.x, canvasSize.y * anchorPosition.y);

        // ����������� �� �������� ��������� � �������
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, anchorPosition.z));

        // ��������� �������� �� ��� Y
        worldPosition.y = transform.position.y; // ��������� ������� �������� �� ������

        // ��������� ������� �������
        transform.position = worldPosition;
    }
}
