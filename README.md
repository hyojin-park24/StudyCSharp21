# StudyCSharp21
박효진 C# 학습 리포지토리

## 1. Basic C#   
기본문법 학습 

### 1-1 C#이란?  
```
◇ 마이크로 소프트에서 개발된 객체 지향 프로그래밍 언어    
◇.NetFramework를 이용하여 프로그래밍하는 대표적인 언어   
◇ 윈도우 프로그래밍, 웹 프로그래밍, 게임 및 모바일 프로그래밍 등 모든 영역에서 사용되는 범용 프로그래밍 언어   
```   

### 1-2 C# 데이터 타입   
+ bool | True or False   
+ byte, sbyte | 8비트   
+ short, ushort | 16비트   
+ int, unit | 32비트   
+ long, ulong | 64비트   
+ Float | 32비트 부동소수점 숫자
+ double | 64비트 부동소수점 숫자   
+ deciaml | 128비트   
+ char | 16비트 유니코드 문자   
+ string | 유니코드 문자열    
+ System.DateTime | 날짜와 시간, 별도의 C#키워드 없음   
+ Object | 모든 타입의 기본 클래스로 모든 유형을 포함 할 수 있음   
+ int.MaxValue, int.MinValue | 최댓값, 최솟값   
+ Null | 값이 아닌 값 "아무리 생각해도 난 NULL을~♬"   

### 1-3 C# 변수 및 상수   
##### 1) 변수   
```   
변수는 변하는 수이다.    
조금 더 쉽게 접근하자면 작성자는 이렇게 말하고 싶다.    
"판도라의 상자"   
```   
+ 변수 : 값을 담아두는 형태   
+ 하나의 데이터 값을 가질 수 있으며, 값이 고정적이지 않고 변할 수 있음   
+ 변수의 자료형   
  + 정수형
    + sybte, byte, short, ushort, int, unit, long, ulong
  + 실수형
    + float, double, decimal
  + 문자형
    + char, string
  + 불린형
    + bool 

##### 1-1) 변수 선언 방법   
**32비트 정수형과 64비트 정수형**   
```
int n; //32비트 정수형
long sum; // 64비트 정수형   
```   

**Hello, World! 문자형**   
```
using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! from .NETCore");
        }
    }
}
```








