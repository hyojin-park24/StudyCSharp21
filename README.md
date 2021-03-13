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
---

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
---

### 1-3) C#데이터 형식 : 데이터 
+ 기본 데이터 형식
+ 변수, 상수, 열거형
+ 복합 데이터 형식
   + 구조체
   + 클래스
   + 배열
+ 값 형식
+ 참조 형식   

#### (1) 기본 데이터 형식
+ 값 형식
   + 숫자 형식
   + 논리 형식   
+ 참조 형식
   + 문자열 형식
   + 오브젝트 형식

#### (2) 값 형식과 참조 형식   
+ 값 형식 (Stack)
   + 변수에서 값을 담는 형식
+ 참조 형식 (Heap)
   + 값이 있는 곳의 위치를 담는 형식   
```
스택   
   - 책 더미와 같은 구조로 생긴 메모리
   - 값 형식의 변수를 저장
   - 저장된 데이터 자체를 제거
힙
   - 코드블록이 끝나도 데이터 유지   
※ 참조 형식의 변수   
   힙 : 데이터 저장
   스택 : 힙의 메모리 주소    
```   
스택
![참조1](/Media/Stack2.png "스택")    
스택과 힙   
<img src="https://github.com/hyojin-park24/StudyCSharp21/blob/main/Media/stack%EA%B3%BC%20Heap2.png"/>    

#### (3) 변수 및 상수  

**(3-1) 변수**
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

#### (3-2) 변수 선언 방법   
**<32비트 정수형과 64비트 정수형>**   
```
int n; //32비트 정수형
long sum; // 64비트 정수형   
```   

**<Hello, World! 문자형>**   
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

#### (3-3) 상수  
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

#### (3-4) ENUM (열거형)   
**열거형이란?**   
enum은 열거형 상수(constant)를 표현하기 위해 태어났다.   
enum을 통해 상수 숫자들을 의미있는 단어로 표현이 가능하고, 
프로그램을 쉽게 읽을 수 있게 만들어 준다.

+ 각 요소는 별도의 지정 없이 첫번째 요소가 0부터 시작함
+ 개발자가 임의로 의미있는 번호 지정 가능
+ 클래스 안 OR 네임스페이스 안에서만 선언 가능
+ 메서드 OR 속성 안에서 선언    

#### (4) 오버플로우 (OverFlow)와 언더플로우 (Underflow)   
```ruby
- 데이터가 흘러 넘쳤을 때: 데이터 형식의 최대값을 넘어가는 데이터를 저장 할 때
- 언더플로우: 최저 값 보다 작은 데이터를 저장할 때   

namespace OverflowTestApp
{
    public partial class Form1_Load : Form
    {
        public Form1_Load()
        {
            InitializeComponent();
        }

        private void Form1_Load_Load(object sender, EventArgs e)
        {
                int flow = 2147483647;
                textBox1.Text = Convert.ToString(flow + 1);
        }
    }
}

```
![참조1](/Media/Overflow.png "오버플로우 예제 결과")   

---

### 1-4) 연산자   
+ 산술 연산자
   +  +, -, *, /, %   
+ 할당 연산자   
   +  =, +=, -=, *=, /=, %=   
+ 증감 연산자   
   +  ++, --    
+ 논리 연산자   
   +  && (And), || (Or), | (Not)    
+ 관계/비교 연산자   
   +  <, >, ==, !=, >=, <=    
+ 비트 연산자   
   +  & (And), | (Or), ^ (XOr)    
   + 비트 내에서의 연산   
+ Shift 연산자   
   +  >>, <<    
   + 값을 이동시킬 수 있는 연산   
+ 조건 연산자   
   +  ?, ??   

**<연산자>**   

```ruby
namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            var p2 = 456; // 지역 변수로 만듦 [숫자 : int]
            Console.WriteLine(123+p2); // 579 [int + int] = int
            Console.WriteLine("123" + p2); // [string + int] = string / 문자열이 하나라도 있으면 문자열 결합으로 바뀜
            Console.WriteLine($"123{p2}"); // [string] / 위와 결과값 같음 지금 방식이 훨씬 편함 (C# 6.0 이후 문자열 만드는 방법)
            Console.WriteLine("123" + "456"); //[string + string] / 123456 [문자 : string]

            // 관계연산자
            int a = 30, b = 30;
            Console.WriteLine( a > b); //false (true,false 화면 출력시, 대문자로 바뀜)
            Console.WriteLine(a < b); // false
            Console.WriteLine( a >= b ); // true
            Console.WriteLine( a<=b ); //true
            Console.WriteLine( a == b ); //true
            Console.WriteLine(a != b); //false ( ! 는 '아니다'는 의미) 

            //논리 연산자
            Console.WriteLine("논리 연산자");
            Console.WriteLine( 10 > 9 && a > 0 );//true ('&&' 는 '그리고' 의미)
            Console.WriteLine( a > b || b > 0); // true ( || 는 '또는' 의미)
            Console.WriteLine(!(a < b)); //true

            // 조건연산자 단항 if 문을 대체 가능
            int c = 30;
            string result = c == 30 ? "삼십" : "삼십아님"; // = > 조건 연산자 써볼게 

            /*string result;
            if (c == 30)
                result = "삼십";
            else
                result = "삼십아님";*/

            Console.WriteLine(result);

            //병합연산자 (NULL 조건부 연산자)

            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d}");

          
            

        }
    }
}
```
**<증감연산자>**   

```ruby
namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}");
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}");
            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}");

            Console.WriteLine($"현재 숫자는 {result++}");
            // ++result 와 result++ 랑 값변환 다름으로 위치 중요 (전치증감 / 후치증감)
            // ++result 는 + 먼저, result++ 는 값 먼저 주고 +를 뒷 작업으로 보냄
            Console.WriteLine($"전치감소 숫자는 {--result}");
            Console.WriteLine($"후치감소 숫자는 {result--}");
        }
    }
}
```

---

### 1-5) 배열(Array)   
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
**<코드 예제 결과 값>**

![결과1](/Media/ArrayTest.png "배열 ")   

---

### 1-6) 코드 흐름의 제어   

```
프로그램의 흐름에 따라 제어할 수 있는 코딩이 존재한다   
```

+ 조건문     
+ 반복문   
+ 점프문   

### (1) 조건문 {if, else, switch}   

#### (1-1) if ~ else문  "만약에~ 그렇지 않으면"   
```ruby
namespace Chap05
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine(); // 콘솔에서 입력값을 변수에 넣기 (할당)

                if(line == "quit") break; // quit 입력하면 프로그램 종료.

                int number = 0;
                int.TryParse(line, out number);  //int.Parse(line);
                //Console.WriteLine(number);
                //todo 아래 로직을 수정하세요
                if (number > 0 )
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0보다 큰 짝수");
                    else
                        Console.WriteLine("0보다 큰 홀수");

                }
                else
                {
                    Console.WriteLine("0보다 작은 수");
                }
                // todo 마지막 
            }

            Console.WriteLine("계산종료!");
        }
    }
}
```   
**<if문 결과값>**   

![결과2](/Media/IfTestApp.png "if문")    

#### (1-2) switch, Label, Break
```
여러개 조건식의 결과를 검사한 후 프로그램의 흐름을 나눔
```

```ruby
namespace SwitchTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("요일을 입력하세요 : ");
                string line = Console.ReadLine(); // 콘솔에서 입력값을 변수에 넣기 (할당)

                if (line == "quit") break; // quit 입력하면 프로그램 종료.
                string day = line;

                /*if ( day == "월요일" )
                {
                    Console.WriteLine("월요일 입니다.");
                }
                else if (day == "화요일")
                {
                    Console.WriteLine("화요일 입니다.");
                }
                else if (day == "수요일")
                {
                    Console.WriteLine("수요일 입니다.");
                }
                else if (day == "목요일")
                {
                    Console.WriteLine("목요일 입니다.");
                }
                else if (day == "금요일")
                {
                    Console.WriteLine("금요일 입니다.");
                }
                else if (day == "토요일")
                {
                    Console.WriteLine("토요일 입니다.");
                }
                else if (day == "일요일")
                {
                    Console.WriteLine("일요일 입니다.");
                }
                else
                {
                    Console.WriteLine("요일이 아닙니다.");
                }*/

                switch (day)
                {
                    case "월요일":
                        Console.WriteLine("월요일 입니다.");
                        break;
                    case "화요일":
                        Console.WriteLine("화요일 입니다.");
                        break;
                    case "수요일":
                        Console.WriteLine("수요일 입니다.");
                        break;
                    case "목요일":
                        Console.WriteLine("목요일 입니다.");
                        break;
                    case "금요일":
                        Console.WriteLine("금요일 입니다.");
                        break;
                    case "토요일":
                        Console.WriteLine("토요일 입니다.");
                        break;
                    case "일요일":
                        Console.WriteLine("일요일 입니다.");
                        break;
                    default:
                        Console.WriteLine("요일이 아닙니다.");
                        break;
                        //if . else if. 문을 switch문으로 바꿀 수 있음 
                }

                Console.WriteLine("계산종료!");
            }
        }
    }
}
```   

**<switch문 결과값>**   

![결과3](/Media/SwitchTestApp.png "switch문 ")     

### (2) 반복문 {While, do, for, foreach}    

#### (2-1) While문 "값이 참일 때, 동안 반복할거야!"   
+ if문과 마찬가지로 true 또는 false가 반환되어야 함   
+ while문의 특징은 조건식이 참일 때 계속해서 반복하여 코드를 실행함    
+ 조건식이 거짓이 되면 루프를 빠져나옴   

**While문의 기본 형태**
```   
while (조건식) 
{
   //반복 실행될 코드
}   
```   

#### (2-2) do While문 "먼저 한번 실행 후 반복할거야!"   
```
do while 문의 주의사항!!   
조건식을 만족하든 만족하지 않든 반드시 한번은 실행이 됨!
```   

**do while문의 기본 형태**   
```
do 
{
   //반복 실행될 코드
}   
while 
(조건식);   
```   

#### (2-3) For문 "값이 참이될 때 까지 반복할거야!"   
+ while문과 큰 차이점은 없음   
+ for문이 확실히 코딩하기 간편함   
+ 초기식에는 반복을 실행하기 전 사용될 **변수를 초기화** 해야함   

**for문의 기본 형태**   
```
for(초기식; 조건식; 증감식;)
{
   //반복해서 실행될 코드
}
```   

#### (2-4) Foreach 문 "순화하며 차례대로 접근할거야!"   

+ 배열이나 컬렉션에서 주로 사용됨   
+ 여러개의 변수를 한 곳에 가져다가 붙인 형태   

**Foreach문의 기본 형태**   
```
foreach (변수 in 배열 혹은 컬렉션)
{
   //실행될 코드
}
```   

**Foreach문 코드 예제**   
```ruby   
namespace ForeachTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sources = { 1, 2, 3, 4, 5, 3, 6, 7, 8, 9, 10 };

           //for
            for (int i = 0; i < sources.Length; i++)
            {
                Console.WriteLine($"sources[i] = {sources[i]}");
            }
            //foreach
            Console.WriteLine("Foreach문");
            var idx = 0;
            foreach(var item in sources)
            {
                Console.WriteLine($"sources = { item}");
            }
        }
    }
}   
```   

#### (2-5) 반복문의 중첩 : 구구단    

**for문의 중첩**   
```
static void Main(string[] args)
{ 
   for (int a = 2; a < 10; a++) 
      {
         for (int b = 1; b < 10; b++) 
            {
               Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            } 
      }
}   
```   

**<구구단 결과 값>**   

![결과4](/Media/Foreach.png "구구단 ")   


### (3) 무한 루프와 제어문 {Infinite, Continue, Break, Goto}   

#### (3-1) 무한 루프 (Infinite loop)   

+ 종료문을 만나지 못하고 끝없이 동작하는 것   
+ 특정 문자가 입력되면 루프를 종료할 수 있음   

**무한 루프 기본 형태**   
```
while (true)
{
   // 값이 참이면 무한루프 시작
   //실행될 코드
}
```   

**Infinite loop 코드 예제**   
```ruby
namespace InfiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); 

            long idx = 0;
            for (; ; )//무한루프
            {
                Console.WriteLine($"idx = {idx++}");
            }
        }
    }
}
```   

#### (3-2) Break      

```
switch문에서 빠져나오기 위하거나 무한루프에서 빠져나오기 위해 사용됨   
```   

#### (3-3) Continue   

```
▶ 조건을 검사하는 부분으로 넘어가서 반복을 계속 수행하는 역할   
▶ continue를 만나면 바로 조건 검사부분으로 넘어감   
▶ 한번 쉬고 계속 반복을 진행   
```   

#### (3-4) Goto   

```
Goto는 해당 레이블로 뛰어넘어버리는 기능   
``` 

**Goto 기본 형태**   
```
...
goto 레이블;   

...
레이블 :   
   //실행될 코드   
...   
```   

---   

## 2. C# 객체지향 문법   

```
클래스 / 캡슐화 / 상속 / 다향성 / C#클래스 확장 / 멤버 유형 확장   
```   

### 2-1) Class  

#### (1) 클래스란?   
**코드 내의 모든 것을 객체로 표현하려는 패러다임**   
   + 객체(Object) : 세상의 모든 것을 지칭   

+ 객체의 표현   
   + 속성 : 데이터   
   + 기능 : 메소드   

+ 클래스 : 객체를 만들기 위한 청사진   
   + Ex) int a = 30;   
      + int : 클래스, 청사진   
      + a : 객체, int의 실체   

#### (2) 클래스의 선언과 객체 생성   

**클래스 선언 기본 형태**   
```
class 클래스 이름   
{
   //데이터와 메소드
}   
```   

#### (3) 생성자와 종료자   

+ 객체를 만드는 생성자   
   + 클래스와 같은 이름
   + 반환 형식 없음   

+ 객체를 파괴하는 종료자   
   + 클래스 이름 앞에 ~ 를 붙인 형태
   + 매게변수 X , 한정자 X   
   + 오버로딩 불가능   
   + 직접 호출할 수 없음   

**생성자와  코드 예제**   
```ruby   
class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("객체사용");

            /*cat cat1 = new cat(); //고양이 객체의 실체(instance) 생성
            cat1.Name = "야옹이";
            cat1.Color = "흰색";
            cat1.Meow();
            cat kitty = new cat();
            kitty.Name = "헬로키티";
            kitty.Color = "하얀색";
            kitty.Meow();
            cat nero = new cat();
            nero.Name = "검은 고양이 네로";
            nero.Color = "검은색";
            nero.Meow();*/

            cat yomi = new cat("요미", "흰색", "암컷");
            yomi.Meow();

        }
    }

    class cat //객체
    {
        public cat() { }

        public cat(string Name)
        {
            this.Name = Name; //this : 객체 자기 자신
        }

        public cat(string Name, string Color) : this(Name) //사용자 정의 생성자
        {
            this.Color = Color;
        }

        public cat(string Name, string Color, string Gender) : this(Name, Color)
        {
            this.Gender = Gender;
        }

        //속성, 특성, 변수
        public string Name; //이름
        public string Color; //색상
        public string Gender; //성별

        //행위, 기능, 메소드
        public void Meow()
        {
            Console.WriteLine($"{this.Name}(색상 {this.Color} / 성별 {this.Gender}) : 야옹!");
        }
    }   
```   

#### (3) 정적 필드와 정적 메소드   

+ static은 메소드나 필드가 클래스 자체에 소속되도록 지정하는 한정자   
+ 인스턴스 소속 필드 VS 클래스 소속 필드   
   + 클래스 소속된 필드 (Static) : 인스턴스를 만들지 않고 클래스의 이름을 통해 필드에 직접 접근   
+ 프로그램 전체에 공유 하는 변수에 사용함   

**정적 필드,메소드 사용 코드 예제**   
```ruby   
 class TestClass
    {
        public static int number;
        public float fnum;

        public static float ProcSomething()
        {
            Console.WriteLine($"{number}, 먼가를 한다.");
            return 1.0f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass aCls = new TestClass();
            TestClass.number = 10;
            aCls.fnum = 3.25f;

            TestClass bCls = new TestClass();
            bCls.fnum = 4.87f;

            TestClass.ProcSomething();
        }


    }   
```   

#### (4) 객체 복사하기 : 얕은 복사 / 깊은 복사   

#### (5) 객체 자신을 지칭하는 This   
+ 객체 내부에서 자신의 필드나 메소드에 접근할 때 사용   

#### (6) 은닉성 (캡슐화)의 구현   
+ 감추고 싶은 것은 감추고, 보여주고 싶은 것만 보여줌   

**은닉성 코드 예제**   
```ruby   
namespace AccessModiFierTestApp

{   //접근 제한, 정보은닉 처리
    class Boiler
    {
        internal int temp = 5; //물 온도 //public>[protecte>private : 접근제한],internal (빈도 낮음)

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60) 
            {
                Console.WriteLine("물의 온도가 일정온도를 벗어났습니다.59℃ 맞춥니다.");
                this.temp = 59;
                return;
            } else
            {
                this.temp = temp; //온도 지정
            }
            
        }

        public int GetTemp(){
            return this.temp;
        }

        public void TurnOnBoiler() {
            Console.WriteLine("보일러를 켭니다.");
        }

        public void TurnOffBoiler() {
            Console.WriteLine("보일러를 끕니다."); 
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kiitturami = new Boiler();
            var currTemp = kiitturami.GetTemp ();
            Console.WriteLine($"현재온도는 {currTemp}℃ 입니다.");
            kiitturami.SetTemp(40);
            kiitturami.TurnOnBoiler();
            kiitturami.SetTemp(59);

            if (kiitturami.GetTemp() >= 59)
            {
                kiitturami.TurnOffBoiler();
            }
        }
    }
}   
```   

#### (7) Class 상속   

+ 부모 클래스와 자식 클래스 관계 파악 중요   

**상속 코드 예제**   
```ruby   
namespace InheritTestApp
{
    class Parent
    {
        protected string Name; // 부모 클래스의 속성 

        public Parent(string Name)
        {
            this.Name = Name; //Name 초기화
            Console.WriteLine($"{this.Name}Parent() 생성자"); //this Name에 parent를 생성하겠음
        }

        public void ParentMethod()
        {
            //...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }
    }

    // 자식클래스 만들게 (부모클래스 상속할거야)
    class Child : Parent
    {
        public String Color; //색상


        public Child(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
        }

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }

        public void Getcolor()
        {
            Console.WriteLine($"{this.Name}의 색상 {this.Color}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent(" 부모 ");
            p.ParentMethod(); // 부모클래스 메서드 실행

            Child c = new Child("자식");
            c.ParentMethod(); //부모의 메서드 실행
            c.ChildMethod(); //자식 클래스 메서드 실행
            c.Color = "황색";
            c.Getcolor();

        }
    }
}
```   

#### (8) 기반클래스와 파생클래스 사이의 형식 "Welcome Zoom!"   
+ 기반클래스와 파생클래스 사이에 족보를 오르내리는 형식 변환 가능   
+ 자식클래스가 부모클래스의 인스턴스로 사용 가능   
+ 코드 수정 시 클래스 기반 내 필요한 작업   

**Zoom Code Example**   
```ruby  
namespace NewOverrideTestApp
{
    class Mammal //포유류
    {
        public string Name { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다.");
        }

        /*public void Move()
        {
            Console.WriteLine($"{this.Name}이(가) 이동한다.");
        }*/

        public virtual void Move()
        {
            Console.WriteLine($"(부모작업){this.Name}이(가) 이동한다.");
        }
    }

    class Dog : Mammal
    {
        /* public void Move()
         {
             Console.WriteLine($"{this.Name}이(가) 네 발로 달린다.");
         }
 */

        public override void Move()
        {
            base.Move(); //부모에 있는 Move 실행
            Console.WriteLine($"{this.Name}이(가) 네 발로 달린다."); //+alpha 실행
        }
    }

    class Huamn : Mammal
    {
        public new void Move()
        {
            //부모의 메서드 숨긴다
            Console.WriteLine($"{this.Name}이(가) 두 발로 움직인다.");
        }
    }

    class Whale : Mammal //고래
    {
        public override void Move()
        {//부모의 메서드를 재정의 
            Console.WriteLine($"{this.Name}이(가) 지느러미로 헤엄친다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog ppopi = new Dog();
            ppopi.Name = "뽀삐";
            ppopi.Move();

            Huamn Edun = new Huamn();
            Edun.Name = "Edun";
            Edun.Move();

            Whale whale = new Whale();
            whale.Name = "고래";
            whale.Move();
        }
    }
}
```   

#### (9) is와 as {C#의 형 변환 연산자}   

+ is   
   + 객체가 해당 형식에 해당하는 검사 후 bool값으로 변환   
+ as   
   + 형식 변환 연산자와 같은 역할   
   + 참조 형식에만 사용   
   + 변환에 실해시, 객체 참조를 null로 만듦   

**TypeCasting Code Example**   
```ruby   
namespace ClassTypeCastApp
{ //형변환
    class 포유류
    {
        public void 키우다 ()
        {
            Console.WriteLine("키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            포유류 _포유류 = new 포유류();
            _포유류.키우다();

            // 자식이 부모클래스로 변환 [묵시적 변환]
            _포유류 = new 강아지();
            _포유류.키우다();
            강아지 쭈쭈;

            if (_포유류 is 강아지)
            {
                쭈쭈 = _포유류 as 강아지;
                쭈쭈.멍멍();
            }

            /*_포유류 = new 고양이();
            _포유류.키우다();
            _포유류.야옹(); => 에러*/



            // [명시적 변환]부모가 자식클래스로 변환 : 들어간다라고 자식을 불러줘야함
            // 근데 명시적 변환은 쓸모 없음. 실행자체가 안됨.
            강아지 뽀삐 = null;
                if (뽀삐 is 포유류)
            {
                Console.WriteLine("이 부분이 실행됩니다.");
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();
            }
          
            /*고양이 로미 = (고양이) new 포유류();
            로미.키우다();
            로미.야옹();*/

        }
    }
}   
```   

#### (10) Tuple    
+ 여러 필드를 담을 수 있는 구조체   
   + 형식의 이름을 갖지 않음   
    + 임시적으로 사용할 복합 데이터 형식 선언에 적합
```ruby

class Program
    {
        static void Main(string[] args)
        {
            var tuple1 = (1, "박효진", "010-8845-2413", "김해시 계동로", true);

            var tuple2 = (Idx: 2, Name: "홍길동", Phone: "010-9999-9999", Address: "경남 창원시 의창구", Marrige: false);

            Console.WriteLine($"{tuple1.Item1} / {tuple1.Item2} / {tuple1.Item3} / {tuple1.Item4} / {tuple1.Item5}");
            Console.WriteLine($"{tuple2.Item1} / {tuple2.Item2} / {tuple2.Item3} / {tuple2.Item4} / {tuple2.Item5}");
            Console.WriteLine($"{tuple2.Idx} / {tuple2.Name} / {tuple2.Phone} / {tuple2.Address} / {tuple2.Marrige}");
        }
    }   
```   

#### (11) Class VS Struct(구조체)   
+ Class   
   + 참조 형식
   + 얕은 복사 (Shallow Copy)   
   + new 연산자와 생성자 필요   
   + 매개 변수 없는 생성자 선언 가능   
   + 상속 가능   

+ Struct   
   + 값 형식   
   + 깊은 복사 (Deep Copy)   
   + 선언 만으로도 생성 가능   
   + 매개 변수 없는 생성자 선언 불가능   
   + 모든 구조체는 System.Object형식을 상속하는    
      System.Value Type으로부터 직접 상속 받음   
      
#### (12) 한 눈에 정리하는 Class 예제!   
```ruby   
public class MyCustomer
{
    // 필드
    private string name;
    private int age;

    // 이벤트 
    public event EventHandler NameChanged;

    // 생성자 (Constructor)
    public MyCustomer()
    {
        name = string.Empty;
        age = -1;
    }

    // 속성
    public string Name
    {
        get { return this.name; }
        set 
        {
            if (this.name != value)
            {
                this.name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }                
        }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    // 메서드
    public string GetCustomerData()
    {
        string data = string.Format("Name: {0} (Age: {1})", 
                    this.Name, this.Age);
        return data;
    }
}   
```   

---   

### 2-2) 인터페이스와 추상 클래스   

+ 인터페이스   
   + 인터페이스는 클래스가 따라야 하는 **약속** 이다   
   + Class는 자기자신을 상속하지 못하기에 쓰이는 인터페이스
   + 인터페이스를 상속하느 인터페이스   
      + 기존 인터페이스에 새로운 기능을 추가한 인터페이스를 만들고 싶을 때   
      + 필요한 인터페이스가 어셈블리로만 제공되는 경우   
      + 필요한 인터페이스를 상속한 클래스가 있는 경우   

+ 추상 클래스   
   + 구현을 가지되 인스턴스는 갖지 못함   
   + 클래스의 접근성에 사용됨   
   + 다른 추상클래스 상속 가능   
      + 자식 추상 클래스에서 부모의 추상 메소드 구현의무는 없음   

**인터페이스와 추상 클래스 코드 예제**   
```ruby
namespace InterfaceTestApp
{
    /*class Ridable //탈것
    {
        public void Ride()
        {
            Console.WriteLine("탈 것!");
        }
    }*/

    interface ICar
    {
        void Run();
        void Ride();
    }

    interface IPlane
    {
        void Fly();

        void Ride();

    }

    class DroneCar : IPlane, ICar
    {
        public void Fly()
        {
            Console.WriteLine("드론카 날다!");
        }

        public void Ride()
        {
            Run();
            Fly();
        }

        public void Run()
        {
            Console.WriteLine("드론카 달리다!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamCar = new DroneCar();
            dreamCar.Ride();
        }

    }
}
```   

```ruby   
namespace LoggerTestApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }

    interface IFormattableLogger : ILogger    // 인터페이스의 상속 
    {
         void WriteLog(string format, params object[] args);
    }

    class ConsoleformatLogger : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger");
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그메시지");

            IFormattableLogger logger2 = new ConsoleformatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12);
        }
    }
}
```   

```ruby   
namespace MultiInterfaceApp
{
    interface IRunnable // 자동차 종류
    {
        void Run();
    }

    interface IFlyable // 비행기 종류
    {
        void Fly();
    }

    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아가자!");
        }

        public void Run()
        {
            Console.WriteLine("달리자!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar DreamCar = new DroneCar();
            DreamCar.Run();
            DreamCar.Fly();

            Console.WriteLine("자동차로 변경 (interface)");
            IRunnable car = DreamCar as IRunnable;
            car.Run();
            //car.Fly(); //erro

            Console.WriteLine("비행기로 변경(interface)");
            IFlyable plane = DreamCar;
            plane.Fly();
            //plane.Run();//erro

        }
    }
}    
```   








### 2-2) 메소드 (Method)   

#### (1) 메소드 (Method)   

+ 메소드란?   
   : 일련의 코드를 하나의 이름 아래 묶은 것     
      + C와 C++의 함수와 비슷한 기능   
      + 클래스 내에서 일련의 코드 블럭을 실행시키는 함수   
      + 0 ~ N개의 인수를 가지고 있음   
      + 하나의 리턴 값을 가지고 있음   
      + 리턴 값이 없으면 리턴 타입을 void로 표시      

+ 메소드의 접근 지정자   
   + private   
   + public   
   + protected   
      + 접근 가능한 범위를 지정   
      
**메소드 기본 예제**   
```
 class Calculator
    {
        static void Main(string[] args)
        {
            int x = Calculator.Plus(3, 4);
            int y = Calculator.Plus(5, 6);
            int z = Calculator.Plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"결과는 {result}");
        }

        private static int Plus(int p1, int p2)
        {
            // throw new NotImplementedException();
            Console.WriteLine($"Input : {p1}, {p2}");
            int result = p1 + p2;
            Console.WriteLine($"Output : {result}");
            return result;
        }
    }   
```   

#### (2) Ref와 Out   

+ ref   
   + 변수값을 그대로 전달 X → 변수의 메모리 주소를 전달 O   
   + 변수를 전달하기 전 초기화 해야함   
   
+ out   
   + ref와 비슷하게 인수를 참조로 전달할 때 사용   
   + 초기화 하지 않고도 전달 가능   

**Ref와 Out 코드 예제**   
```ruby   
  class Program
    {
        static void Main(string[] args)
        {
            int a = 22, b = 3;
            int val = 0;
            int rem = 0;
            Divide(a, b, out val, out rem);

            Console.WriteLine($"{a},{b} : a/b = {val}, a%b = {rem} ");

            bool isSucced = int.TryParse("1000.74", out int result);
            Console.WriteLine($"변환결과{isSucced} , result값 {result}");
            

        }

        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
    }   
```   

#### (3) 메소드 오버로딩   

+ 하나의 메소드 이름에 여러 개의 구현을 올리는 것   
+ 매개 변수의 수와 형식을 분석해 호출할 메소드 결정   
+ 이름에 대한 고민을 덜어줌   
+ 코드의 일관성을 제공   
+ 똑같은 메소드 명에 매개변수에 따라 호출되는 메소드가 다름   

**오버로딩 메소드 기본 예제**   
```
class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기!");

            int x = Calculator.Plus(3,4);
            Console.WriteLine($"3 + 4 = {x}");

            float y = Calculator.Plus(3.14f, 5.6f);
            Console.WriteLine($"3.14 + 5.6 = {y}");
            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, 5.6)}");
            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, "5")}");
            int z = Calculator.Plus(7,8,9);

            
            // [가변길이 매개변수]밑에것처럼 쓰면 매개변수 쓰기 짱 편해! 
            int total = 0;
            total = sum(1,2, 4, 8, 24);
            Console.WriteLine($"합계는 {total}");
            Console.WriteLine($"10까지의 합은 {sum(1,2,3,4,5,6,7,8,9,10)}");

            int[] arrs = new int[] {1,2,3,4,5,6,7,8,9,10 };
            Console.WriteLine($"10까지의 합은 {sum(arrs)}");
        }

        private static int Plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

        private static int sum(params int [] args)
        {
            int result = 0;
            foreach (var arg in args)
            {
                result += arg;
            }
            return result;
        }


        private static double Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = v1 + p2;
            return result;
        }

        private static double Plus(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }

        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }
    }
    
```   
    
#### (4) 명명된 매개변수와 선택적 매개변수   

```ruby   
 class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("박효진", "010-8845-2413");

           if( PrintProfile(null, "010-1111-2222") == -1);
            {
                Console.WriteLine("프로필 출력 시 오류가 발생했습니다.");
            }

            //[명명된 매개변수 - "",] 가독성에 짱 좋음!
            /*PrintProfile(phone:"010-1708-3826", name: "홍길동");
            PrintProfile(name:"홍길순", phone : "010-2708-3878" );*/
            
            //[선택적 매개변수 ] 순서중요! 뒤에서부터 값이 입력이 되어야만 가능
            PrintProfile("최백호");
        }
        public static int PrintProfile (string name, string phone = "010-8845-2413") // voide 쓸 때와 int 쓸 때와 다른 것을 인지해야 함
        {    if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1;
            }

            //프로필 출력
            Console.WriteLine($"이름 : {name}, 폰 번호 : {phone}");
            return 0;
        }
    }   
```   

#### (5) Swap메소드   
   + 정렬할 때 쓰이는 메소드 
   + DB의 ordeby, desc, esc와 같음   

```ruby   
class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;
            Console.WriteLine($"Before Swap {x},{y}");
            Program.Swap(/*ref*/ x, /*ref*/ y); //정렬 기반

            Console.WriteLine($"After Swap {x},{y}");
        }

        private static void Swap(/*ref*/ int p1, /*ref*/ int p2) //refurence : 주소 
        // Swap 메소드 : 정렬할 때 쓰임 ( DB 의 orderby, desc, esc 와 같음) 
        {
            int temp = p1; // temp 47 이 들어온겨 
            p1 = p2; // p1 = 5, p2 =5 
            p2 = temp; // p2 = 47
        }
    }
```   


    
    















  










참조: https://blog.hexabrain.net/128 [끝나지 않는 프로그래밍 일기]
      https://076923.github.io/posts/C-26/[오버플로우 코드 ]





