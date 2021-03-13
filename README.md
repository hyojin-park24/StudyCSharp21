# StudyCSharp21
박효진 C# 학습 리포지토리

## 1. Basic C#   
기본문법 학습 

### 1-1) C#이란?  
```
◇ 마이크로 소프트에서 개발된 객체 지향 프로그래밍 언어    
◇.NetFramework를 이용하여 프로그래밍하는 대표적인 언어   
◇ 윈도우 프로그래밍, 웹 프로그래밍, 게임 및 모바일 프로그래밍 등
   모든 영역에서 사용되는 범용 프로그래밍 언어   
```   

### 1-2) C# 데이터 타입   
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

### 1-3) C# 변수 및 상수   
#### (1) 변수   
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
+ 모든 C# 변수의 이름은 대소문자를 구별(case-sensitive)한다.

#### 1-1) 변수 선언 방법   
**32비트 정수형과 64비트 정수형**   
```
int n; //32비트 정수형
long sum; // 64비트 정수형   
```   

**Hello, World! 문자형**   
```ruby
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

#### (2) 상수  
```ruby
상수란?

코드를 작성하다가 나도 모르게 값을 변경하지 말아야 할 변수를 건드려서 버그가 발생할 수 있다.
이 문제를 쉽게 해결해주는 const라는 상수이다.
const를 사용하게 되면 한번 초기화 된 값은 절대 변하지 않는것이 변수와의 차이점 이다.

using System;

namespace ConstTestApp
{
    class Program
    {
        enum Season // 열거형 ( 하나의 타입으로 표현 )
        {
            Spring,
            Summer,
            Fall,
            Winter
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double PI = 3.141592;
            Console.WriteLine($"원주율의 값는 {PI}");
            // PI = 6.345;

            Season mySeason = Season.Summer;
            Console.WriteLine($"지금 계절은 핫 써머 아 핫핫 써머 일까요? {mySeason} 였습니다!");

            int a = 0; //null 허용 안됌
            Console.WriteLine($"a는 {a}");
            int? b = null;
            Console.WriteLine($"b는 {b}");

        }
    }
}   
```   

#### (2-1) ENUM (열거형)   
**열거형이란?**   
enum은 열거형 상수(constant)를 표현하기 위해 태어났다.   
enum을 통해 상수 숫자들을 의미있는 단어로 표현이 가능하고, 
프로그램을 쉽게 읽을 수 있게 만들어 준다.

+ 각 요소는 별도의 지정 없이 첫번째 요소가 0부터 시작함
+ 개발자가 임의로 의미있는 번호 지정 가능
+ 클래스 안 OR 네임스페이스 안에서만 선언 가능
+ 메서드 OR 속성 안에서 선언    

### 1-4) C# 배열(Array)   
```
배열이란?   
동일한 데이터 타입의 집합이다.   

쉽게 이야기를 해보자면,   
반복적인 코드 동작을 최대한 효율적으로 코드를 작성하기 위해 태어난 아이가 '배열'이다.
MBTI의 ENTJ가 가장 좋아하는 구성이다.
```

```ruby
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList( new[] { 80,74,81,90,34});

            var loc = array.IndexOf(81);
            array.Insert(loc, 50);

            Console.WriteLine("81위치에 50추가");
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("90 삭제");
            loc = array.IndexOf(90);

            array.RemoveAt(4);
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("정렬");
            array.Sort(); // 정렬
            foreach (var item in array)

            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
```
**코드 예제 결과 값**

![결과1](/Media/ArrayTest.png "배열 ")  



참조: https://blog.hexabrain.net/128 [끝나지 않는 프로그래밍 일기]





