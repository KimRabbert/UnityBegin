using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 1. 초기화
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    // a. 활성화
    void OnEnable() // 게임 오브젝트가 활성화 되었을 때
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    // 2. 물리
    void FixedUpdate()  // 물리 연산 업데이트 (CPU 사용량 높음)
    {
        Debug.Log("이동~");
    }

    // 3. 게임 로직
    void Update()   // 환경에 따라 실행 주기 변경, 60fps
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate()   // 모든 업데이트 후 호출
    {
        Debug.Log("경험치 획득.");
    }

    // b. 비활성화
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    // 4. 해체
    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
