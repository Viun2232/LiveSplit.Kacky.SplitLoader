# Kacky Split Loader
LiveSplit용 Kackiest Kacky을 위한 Split Loader 컴포넌트

## 설명
TrackMania의 Kackiest Kacky를 플레이할 때, 매번 맵에 따라 스플릿 파일을 수동으로 로드하는 것이 번거로워 직접 만든 컴포넌트입니다.  
**스킬 0%, ChatGPT 100%**로 제작되어 버그나 불필요한 코드가 포함되어 있을 수 있습니다. xd

> **주의: 이 컴포넌트는 TimerPause 컴포넌트와 함께 사용해야 합니다.**  
> [ROFLailXGOD의 TimerPause](https://github.com/ROFLailXGOD/TimerPause)

## 설치 방법
ROFLailXGOD의 TimerPause 컴포넌트를 설치하는 걸 잊지 마세요.
1. 릴리즈 탭에서 최신 버전의 `LiveSplit.Kacky.SplitLoader.dll`과 `Kackiest Kacky.zip`을 다운로드합니다.
2. `Kackiest Kacky.zip` 파일을 원하는 폴더에 압축 해제합니다.
3. LiveSplit 설치 폴더의 `Components` 폴더에 `LiveSplit.Kacky.SplitLoader.dll` 파일을 둡니다.
4. LiveSplit 실행 → 우클릭 → Edit Layout... → "+" 버튼 → Control → Kacky Split Loader 추가
   - (참고: TimerPause는 Other → Timer Pause에 있습니다.)
5. Layout Setting → Kacky Split Lader 탭에서 `Kackiest Kacky.zip`을 압축 해제한 폴더 경로를 설정합니다.

## 사용 방법
- 먼저, LiveSplit Settings에서 Pause 단축키를 설정하는 것을 추천합니다. (Global Hotkeys를 체크하면 게임을 플레이하면서 정지할 수도 있습니다.)
- 입력창에 플레이할 맵 번호를 입력합니다.
- **Load 버튼**이나 **Enter 키**를 누르면 해당 스플릿 파일을 자동으로 로드합니다.
- 타이머를 시작하고 Kackiest Kacky를 즐기세요.
- 맵이 변경될 때마다 새로운 맵 번호를 입력하고 Load하면 됩니다.
- 이전 스플릿 기록은 TimerPause를 통해 자동 저장됩니다.
