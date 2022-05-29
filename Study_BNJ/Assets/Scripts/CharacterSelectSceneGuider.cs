using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 이 클래스는 캐릭터 선택 씬에서 안내 역활 및 캐릭터 선택에 도움을 준다.
/// </summary>
public class CharacterSelectSceneGuider : MonoBehaviour
{
    // user id,
    // 크레이지 아케이드에 온걸 환영합니다! ← 환영 문구
    // 캐릭터 선택 및 캐릭터 3개

    // 스타트는 ? : 처음에
    private void Start()
    {
        Debug.LogError("호롤로로 Called");
        
    }

    // 업데이트는 ? : 초마다 여러번 호출
    private void Update()
    {
        Debug.Log("Update Called");

    }
}
