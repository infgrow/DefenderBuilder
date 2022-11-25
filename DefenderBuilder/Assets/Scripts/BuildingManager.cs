using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour {

    private Camera mainCamera;
    private BuildingTypeListSO buildingTypeList;
    private BuildingTypeSO buildingType;

    private void Start() {
        mainCamera = Camera.main;

        buildingTypeList = Resources.Load<BuildingTypeListSO>(typeof(BuildingTypeListSO).Name);
        buildingType = buildingTypeList.list[0];
    }
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Instantiate(buildingType.prefab, GetMouseWorldPosition(), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            buildingType = buildingTypeList.list[0];
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            buildingType = buildingTypeList.list[1];
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            buildingType = buildingTypeList.list[2];
        }
    }

    private Vector3 GetMouseWorldPosition() {
        Vector3 mousePoint = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePoint.z = 0f;
        return mousePoint;
    }
}
