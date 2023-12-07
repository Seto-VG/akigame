using System;
using UnityEngine;

public class DragController : MonoBehaviour
{
    // ドロップ可能オブジェクト
    public Draggable dropObj;

    void Start()
    {
        dropObj.beforeBeginDrag = () =>
        {
            // Debug.Log("ドラッグ前に呼び出される処理");
        };
        dropObj.onDropSuccess = (MonoBehaviour area, Action resetAction) =>
        {
            GameManager.instance.GameClear();
            Debug.Log("ドラッグ成功時に呼び出される処理");
        };
        dropObj.onDropFail = (Action resetAction) =>
        {
            // Debug.Log("ドラッグ失敗時に呼び出される処理");
        };
    }
}